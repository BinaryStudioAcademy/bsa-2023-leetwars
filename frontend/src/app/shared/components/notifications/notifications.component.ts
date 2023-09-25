import { Component, Input, OnInit } from '@angular/core';
import { ChallengeService } from '@core/services/challenge.service';
import { NotificationService } from '@core/services/notification.service';
import { TypeNotification } from '@shared/enums/type-notification';
import { INotificationModel } from '@shared/models/notifications/notifications';

@Component({
    selector: 'app-notifications',
    templateUrl: './notifications.component.html',
    styleUrls: ['./notifications.component.sass'],
})
export class NotificationsComponent implements OnInit {
    @Input() notifications: INotificationModel[];

    public typeNotification = TypeNotification;

    constructor(private notificationService: NotificationService, private challengeService: ChallengeService) {}

    public ngOnInit(): void {
        this.notificationService.currentNotifications.subscribe((notifications: INotificationModel[]) => {
            this.notifications = notifications;
        });
    }

    public onCodeFightStart(notification: INotificationModel) {
        this.notificationService.removeNotification(notification);
        this.notificationService.hideNofitications();

        this.challengeService.sendCodeFightStart(notification).subscribe();
    }

    public onCodeFightRefuse(notification: INotificationModel) {
        this.notificationService.removeNotification(notification);
    }
}
