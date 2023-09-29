import { Component, OnDestroy, OnInit } from '@angular/core';
import { NavigationStart, Router } from '@angular/router';
import { BaseComponent } from '@core/base/base.component';
import { NotificationHubService } from '@core/hubs/notifications-hub.service';
import { AuthService } from '@core/services/auth.service';
import { HeaderService } from '@core/services/header.service';
import { NotificationService } from '@core/services/notification.service';
import { NotificationStorageService } from '@core/services/notification-storage.service';
import { ToastrNotificationsService } from '@core/services/toastr-notifications.service';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { fadeInOut } from '@shared/animations/fade-in-out.animation';
import { TypeNotification } from '@shared/enums/type-notification';
import { INotificationModel } from '@shared/models/notifications/notifications';
import { IPageSettings } from '@shared/models/page-settings';
import { IUser } from '@shared/models/user/user';
import { takeUntil } from 'rxjs';

import { ConfirmationModalComponent } from '../confirmation-modal/confirmation-modal.component';

@Component({
    selector: 'app-header',
    templateUrl: './header.component.html',
    styleUrls: ['./header.component.sass'],
    animations: [fadeInOut],
})
export class HeaderComponent extends BaseComponent implements OnInit, OnDestroy {
    constructor(
        private authService: AuthService,
        private modalService: NgbModal,
        private router: Router,
        private headerService: HeaderService,
        private toastrService: ToastrNotificationsService,
        private notificationService: NotificationService,
        private notificationStorage: NotificationStorageService,
        private notificationHub: NotificationHubService,
    ) {
        super();
        this.authService.currentUser$.pipe(takeUntil(this.unsubscribe$)).subscribe((user) => {
            this.user = user!;
        });

        this.router.events.subscribe((event) => {
            if (event instanceof NavigationStart) {
                this.showMenu = false;
            }
        });
    }

    private page: IPageSettings = {
        pageNumber: 0,
        pageSize: 10,
    };

    private isLastPage = false;

    public isNotificationsDropdownDisplayed: boolean = false;

    private newNotificationsCollection: INotificationModel[] = [];

    private seenNotificationsCollection: INotificationModel[] = [];

    private countNotificationsFromStorage: number = 0;

    private countRealTimeNotifications: number = 0;

    public showMenu: boolean = false;

    user: IUser;

    async ngOnInit() {
        await this.notificationHub.start();
        this.listeningNotificationHub();
        this.getNotifications();
        this.countUnreadNotifications();
    }

    private getNotifications() {
        if (this.isLastPage) {
            return;
        }

        this.page.pageNumber++;

        this.notificationStorage.getUserNotifications(this.page)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe({
                next: (notifications) => {
                    if (!notifications.length) {
                        this.isLastPage = true;

                        return;
                    }
                    this.newNotificationsCollection = [...this.newNotificationsCollection, ...notifications.filter(e => !e.isRead)];
                    this.seenNotificationsCollection = [...this.seenNotificationsCollection, ...notifications.filter(e => e.isRead)];
                },
                error: () => {
                    this.toastrService.showError('Server connection error');
                    this.router.navigate(['/']);
                },
            });
    }

    private countUnreadNotifications() {
        this.notificationStorage.getUnreadNotificationsCount()
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe({
                next: (count) => {
                    this.countNotificationsFromStorage = count;
                },
                error: () => {
                    this.toastrService.showError('Server connection error');
                },
            });
    }

    private readNotifications() {
        this.newNotificationsCollection.forEach(x => {
            x.isRead = true;
        });
        this.notificationStorage.updateStatusToRead([this.user.id])
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe({
                next: () => {
                    this.countUnreadNotifications();
                },
                error: () => {
                    this.toastrService.showError('Server connection error');
                    this.router.navigate(['/']);
                },
            });

        this.seenNotificationsCollection = [...this.seenNotificationsCollection, ...this.newNotificationsCollection];
        this.newNotificationsCollection = [];
        this.countRealTimeNotifications = 0;
    }

    public showNotifications() {
        if (this.isNotificationsDropdownDisplayed) {
            this.readNotifications();
        }
        this.isNotificationsDropdownDisplayed = !this.isNotificationsDropdownDisplayed;
    }

    public get countNotification() {
        return this.countNotificationsFromStorage + this.countRealTimeNotifications;
    }

    public get newNotifications() {
        return this.newNotificationsCollection;
    }

    public get seenNotifications() {
        return this.seenNotificationsCollection;
    }

    onLogOut() {
        const modalRef = this.modalService.open(ConfirmationModalComponent, { windowClass: 'log-out-modal' });

        modalRef.componentInstance.titleText = 'Do you really wish to log out?';
        modalRef.componentInstance.bodyText = `After confirmation you will be logged out of system,
            with all your data safe while you're away`;
        modalRef.componentInstance.buttons = [
            {
                text: 'Yes',
                handler: () => {
                    this.headerService.setShowHeader(false);
                    this.authService.logout();
                    this.router.navigate(['auth/login']);
                    modalRef.close();
                    this.toastrService.showSuccess('Successfully logged out');
                },
            },
            {
                text: 'No',
                handler: () => {
                    this.showMenu = false;
                    modalRef.dismiss();
                },
            },
        ];
    }

    onScroll() {
        if (this.isLastPage) {
            return;
        }

        this.getNotifications();
    }

    goToProfile() {
        this.showMenu = false;
        this.router.navigate(['/user/profile']);
    }

    private listeningNotificationHub() {
        this.notificationHub.listenMessages((msg: INotificationModel) => {
            if (msg.typeNotification !== TypeNotification.CodeFightRequestStart) {
                this.newNotificationsCollection = [...this.newNotificationsCollection, msg];
                this.countRealTimeNotifications++;
            }
        });
    }

    override ngOnDestroy() {
        this.notificationHub.stop();
        super.ngOnDestroy();
        if (this.isNotificationsDropdownDisplayed) {
            this.readNotifications();
            this.isNotificationsDropdownDisplayed = !this.isNotificationsDropdownDisplayed;
        }
    }

    trackByFn(index: number, item: INotificationModel) {
        return item.dateSending;
    }
}
