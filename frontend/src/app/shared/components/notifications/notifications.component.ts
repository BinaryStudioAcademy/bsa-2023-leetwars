import { AfterViewInit, Component, ElementRef, HostListener, Input, OnInit, ViewChild } from '@angular/core';
import { BaseComponent } from '@core/base/base.component';
import { AuthService } from '@core/services/auth.service';
import { EventService } from '@core/services/event.service';
import { NotificationService } from '@core/services/notification.service';
import { ToastrNotificationsService } from '@core/services/toastr-notifications.service';
import { UserService } from '@core/services/user.service';
import { FriendshipStatus } from '@shared/enums/friendship-status';
import { TypeNotification } from '@shared/enums/type-notification';
import { IUpdateFriendship } from '@shared/models/friendship/update-friendship';
import { INotificationModel } from '@shared/models/notifications/notifications';
import { IUser } from '@shared/models/user/user';
import { takeUntil } from 'rxjs';

@Component({
    selector: 'app-notifications',
    templateUrl: './notifications.component.html',
    styleUrls: ['./notifications.component.sass'],
})
export class NotificationsComponent extends BaseComponent implements OnInit, AfterViewInit {
    constructor(
        private notificationService: NotificationService,
        private userService: UserService,
        private authService: AuthService,
        private toastrNotification: ToastrNotificationsService,
        private eventService: EventService,
    ) {
        super();
    }

    private readonly TOP_OFFSET = 40;

    private readonly RIGHT_OFFSET = 300;

    private readonly HALF = 2;

    private readonly NEGATIVE = -1;

    @Input() public notifications: INotificationModel[];

    @ViewChild('notificationsContainer') public notificationsContainer: ElementRef;

    @HostListener('window:resize', ['$event'])
    onResize() {
        this.calculateRigthPosition();
        this.calculateTopPosition();
    }

    public ngAfterViewInit() {
        this.calculateTopPosition();
        this.calculateRigthPosition();
    }

    public calculateTopPosition() {
        const containerHeight = this.notificationsContainer.nativeElement.offsetHeight;
        const topValue = containerHeight / this.HALF + this.TOP_OFFSET;

        this.notificationsContainer.nativeElement.style.top = `${topValue}px`;
    }

    public calculateRigthPosition() {
        const screenWidth = window.innerWidth || document.documentElement.clientWidth || document.body.clientWidth;
        const rightValue = this.NEGATIVE * (screenWidth / this.HALF) + this.RIGHT_OFFSET;

        this.notificationsContainer.nativeElement.style.right = `${rightValue}px`;
    }

    private currentUser: IUser;

    public ngOnInit(): void {
        this.authService
            .getUser()
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe({
                next: (user) => {
                    this.currentUser = user;
                },
                error: () => {
                    this.toastrNotification.showError('Server connection error');
                },
            });
    }

    typeNotification = TypeNotification;

    public acceptFriendship(notification: INotificationModel) {
        const updateRequest = notification.updateFriendship;

        updateRequest.friendshipStatus = FriendshipStatus.Accepted;
        updateRequest.userId = this.currentUser.id;

        this.updateFriendship(updateRequest);
        this.removeAndUpdate(notification);
    }

    public declineFriendship(notification: INotificationModel) {
        const updateRequest = notification.updateFriendship;

        updateRequest.friendshipStatus = FriendshipStatus.Declined;
        updateRequest.userId = this.currentUser.id;

        this.updateFriendship(updateRequest);
        this.removeAndUpdate(notification);
    }

    private removeAndUpdate(notification: INotificationModel) {
        this.notificationService.removeNotification(notification);
        this.notificationService.updateNotificationsModal();
        setTimeout(() => {
            this.calculateTopPosition();
        }, 50);
    }

    private updateFriendship(updateRequest: IUpdateFriendship) {
        this.userService
            .updateFriendshipRequest(updateRequest)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe({
                next: (user) => {
                    this.eventService.userFriendshipChanged(user);
                },
                error: (error) => {
                    this.toastrNotification.showError(error);
                },
            });
    }
}
