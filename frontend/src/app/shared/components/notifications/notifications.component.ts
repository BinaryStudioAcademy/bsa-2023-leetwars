import { Component, Input, OnInit } from '@angular/core';
import { BaseComponent } from '@core/base/base.component';
import { AuthService } from '@core/services/auth.service';
import { CodeFightService } from '@core/services/code-fight.service';
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
export class NotificationsComponent extends BaseComponent implements OnInit {
    constructor(
        private notificationService: NotificationService,
        private userService: UserService,
        private authService: AuthService,
        private toastrNotification: ToastrNotificationsService,
        private eventService: EventService,
        private codeFightService: CodeFightService,
    ) {
        super();
    }

    private currentUser: IUser;

    typeNotification = TypeNotification;

    @Input() notifications: INotificationModel[];

    ngOnInit(): void {
        this.getCurrentUser();

        this.notificationService.currentNotifications.subscribe((notifications: INotificationModel[]) => {
            this.notifications = notifications;
        });
    }

    updateFriendshipStatus(notification: INotificationModel, status: FriendshipStatus) {
        const updateRequest = notification.updateFriendship;

        updateRequest.friendshipStatus = status;
        updateRequest.userId = this.currentUser.id;

        this.updateFriendship(updateRequest);
        this.notificationService.removeNotification(notification);
    }

    acceptFriendship(notification: INotificationModel) {
        this.updateFriendshipStatus(notification, FriendshipStatus.Accepted);
    }

    declineFriendship(notification: INotificationModel) {
        this.updateFriendshipStatus(notification, FriendshipStatus.Declined);
    }

    onCodeFightStart(notification: INotificationModel) {
        this.notificationService.removeNotification(notification);
        this.notificationService.hideNofitications();

        this.codeFightService.sendCodeFightStart(notification).subscribe();
    }

    onCodeFightRefuse(notification: INotificationModel) {
        this.codeFightService.sendCodeFightRequestEnded(notification).subscribe();

        this.notificationService.removeNotification(notification);
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

    private getCurrentUser() {
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
}
