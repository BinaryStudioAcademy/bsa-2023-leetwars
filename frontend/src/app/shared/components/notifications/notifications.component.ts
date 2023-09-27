import { Component, Input, OnInit } from '@angular/core';
import { CodeFightService } from '@core/services/code-fight.service';
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

    typeNotification = TypeNotification;

    constructor(private notificationService: NotificationService, private codeFightService: CodeFightService) {}

    ngOnInit(): void {
        this.notificationService.currentNotifications.subscribe((notifications: INotificationModel[]) => {
            this.notifications = notifications;
        });
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
}
