import { Component, Input, OnInit } from '@angular/core';
import { BaseComponent } from '@core/base/base.component';
import { AuthService } from '@core/services/auth.service';
import { EventService } from '@core/services/event.service';
import { NotificationService } from '@core/services/notification.service';
import { ToastrNotificationsService } from '@core/services/toastr-notifications.service';
import { UserService } from '@core/services/user.service';
import { FriendshipStatus } from '@shared/enums/friendship-status';
import { TypeNotification } from '@shared/enums/type-notification';
import { UpdateFriendship } from '@shared/models/friendship/update-friendship';
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
    ) {
        super();
    }

    @Input() notifications: INotificationModel[];

    private currentUser: IUser;

    ngOnInit(): void {
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

    public onYes(notification: INotificationModel) {
        this.notificationService.removeNotification(notification);

        this.notificationService.hideNofitications();
    }

    public acceptFriendship(notification: INotificationModel) {
        const updateRequest = notification.updateFriendship;

        updateRequest.friendshipStatus = FriendshipStatus.Accepted;
        updateRequest.userId = this.currentUser.id;

        this.updateFriendship(updateRequest);
        this.hideAndRemove(notification);
    }

    public declineFriendship(notification: INotificationModel) {
        const updateRequest = notification.updateFriendship;

        updateRequest.friendshipStatus = FriendshipStatus.Declined;
        updateRequest.userId = this.currentUser.id;

        this.updateFriendship(updateRequest);
        this.hideAndRemove(notification);
    }

    private hideAndRemove(notification: INotificationModel) {
        this.notificationService.removeNotification(notification);
        this.notificationService.hideNofitications();
    }

    private updateFriendship(updateRequest: UpdateFriendship) {
        this.userService
            .updateFriendshipRequest(updateRequest)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe({
                next: (user) => {
                    this.eventService.userFriendshipChanged(user);
                },
                error: () => {
                    this.toastrNotification.showError('Server connection error');
                },
            });
    }
}
