import { Component, Input, OnInit } from '@angular/core';
import { BaseComponent } from '@core/base/base.component';
import { AuthService } from '@core/services/auth.service';
import { CodeFightService } from '@core/services/code-fight.service';
import { EventService } from '@core/services/event.service';
import { NotificationService } from '@core/services/notification.service';
import { ToastrNotificationsService } from '@core/services/toastr-notifications.service';
import { UserService } from '@core/services/user.service';
import { longFadeIn } from '@shared/animations/long-fade-in.animation';
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
    animations: [longFadeIn],
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

    @Input() notification: INotificationModel;

    @Input() isUnread: boolean;

    private currentUser: IUser;

    typeNotification = TypeNotification;

    friendshipStatus = FriendshipStatus;

    @Input() notifications: INotificationModel[];

    ngOnInit(): void {
        this.getCurrentUser();
    }

    updateFriendshipStatus(notification: INotificationModel, status: FriendshipStatus) {
        const updateRequest = notification.updateFriendship;

        updateRequest.friendshipStatus = status;
        updateRequest.userId = this.currentUser.id;

        this.updateFriendship(updateRequest);
    }

    acceptFriendship(notification: INotificationModel) {
        this.updateFriendshipStatus(notification, FriendshipStatus.Accepted);
    }

    declineFriendship(notification: INotificationModel) {
        this.updateFriendshipStatus(notification, FriendshipStatus.Declined);
    }

    onCodeFightStart() {
        this.notificationService.removeNotification(this.notification);
        this.codeFightService.sendCodeFightStart(this.notification).subscribe();
    }

    onCodeFightRefuse() {
        this.codeFightService.sendCodeFightRequestEnded(this.notification).subscribe();
        this.notificationService.removeNotification(this.notification);
    }

    private updateFriendship(updateRequest: IUpdateFriendship) {
        this.userService
            .updateFriendshipRequest(updateRequest)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe({
                error: (error) => {
                    this.toastrNotification.showError(error);
                },
            });
    }

    private getCurrentUser() {
        this.authService.getUser().subscribe((user: IUser) => {
            this.currentUser = user;
        });
    }
}
