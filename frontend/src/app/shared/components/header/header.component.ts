import { Component, OnDestroy, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { NotificationHubService } from '@core/hubs/notifications-hub.service';
import { AuthService } from '@core/services/auth.service';
import { HeaderService } from '@core/services/header-service';
import { NotificationService } from '@core/services/notification.service';
import { ToastrNotificationsService } from '@core/services/toastr-notifications.service';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { INotificationModel } from '@shared/models/notifications/notifications';
import { IUser } from '@shared/models/user/user';

import { ConfirmationModalComponent } from '../confirmation-modal/confirmation-modal.component';

@Component({
    selector: 'app-header',
    templateUrl: './header.component.html',
    styleUrls: ['./header.component.sass'],
})
export class HeaderComponent implements OnInit, OnDestroy {
    constructor(
        private authService: AuthService,
        private modalService: NgbModal,
        private router: Router,
        private headerService: HeaderService,
        private toastrService: ToastrNotificationsService,
        private notificationService: NotificationService,
        private notificationHub: NotificationHubService,
    ) {
        this.authService.getUser().subscribe((user) => {
            this.user = user;
        });
    }

    public showMenu: boolean = false;

    public user: IUser;

    async ngOnInit() {
        await this.notificationHub.start();
        this.listeningHub();
    }

    showNotifications() {
        this.notificationService.showNotifications();
    }

    get countNotification() {
        return this.notificationService.countNotification;
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

    public goToProfile() {
        this.showMenu = false;
        this.router.navigate(['/user/profile']);
    }

    private listeningHub() {
        this.notificationHub.listenMessages((msg: INotificationModel) => {
            this.notificationService.addNotification(msg);
        });
    }

    ngOnDestroy() {
        this.notificationHub.stop();
    }
}
