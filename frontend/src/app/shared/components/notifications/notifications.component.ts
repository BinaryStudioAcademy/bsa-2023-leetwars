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
    @Input() notification: INotificationModel;

    @Input() isUnread: boolean;

    typeNotification = TypeNotification;

    constructor(private notificationService: NotificationService, private codeFightService: CodeFightService) {}

    onCodeFightStart() {
        this.notificationService.removeNotification(this.notification);
        this.codeFightService.sendCodeFightStart(this.notification).subscribe();
    }

    onCodeFightRefuse() {
        this.codeFightService.sendCodeFightRequestEnded(this.notification).subscribe();
        this.notificationService.removeNotification(this.notification);
    }
}
