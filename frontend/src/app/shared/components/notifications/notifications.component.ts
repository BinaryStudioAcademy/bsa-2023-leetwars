import { Component, Input } from '@angular/core';
import { CodeFightService } from '@core/services/code-fight.service';
import { NotificationService } from '@core/services/notification.service';
import { longFadeIn } from '@shared/animations/long-fade-in.animation';
import { TypeNotification } from '@shared/enums/type-notification';
import { INotificationModel } from '@shared/models/notifications/notifications';

@Component({
    selector: 'app-notifications',
    templateUrl: './notifications.component.html',
    styleUrls: ['./notifications.component.sass'],
    animations: [longFadeIn],
})
export class NotificationsComponent {
    @Input() notifications: INotificationModel[];

    @Input() isUnread: boolean;

    trackByFn(index: number, item: INotificationModel) {
        return item.dateSending;
    }

    typeNotification = TypeNotification;

    constructor(private notificationService: NotificationService, private codeFightService: CodeFightService) {}

    onCodeFightStart(notification: INotificationModel) {
        this.notificationService.removeNotification(notification);
        if (!notification.sender.imagePath) {
            notification.sender.imagePath = '';
        }

        this.codeFightService.sendCodeFightStart(notification).subscribe();
    }

    onCodeFightRefuse(notification: INotificationModel) {
        this.codeFightService.sendCodeFightRequestEnded(notification).subscribe();
        if (!notification.sender.imagePath) {
            notification.sender.imagePath = '';
        }

        this.notificationService.removeNotification(notification);
    }
}
