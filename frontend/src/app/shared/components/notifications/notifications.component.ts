import { Component, Input } from '@angular/core';
import { NotificationService } from '@core/services/notification.service';
import { TypeNotification } from '@shared/enums/type-notification';
import { INotificationModel } from '@shared/models/notifications/notifications';

@Component({
    selector: 'app-notifications',
    templateUrl: './notifications.component.html',
    styleUrls: ['./notifications.component.sass'],
})
export class NotificationsComponent {
    constructor(private notificationService: NotificationService) {}

    @Input() notifications: INotificationModel[];

    typeNotification = TypeNotification;

    public onYes(notification: INotificationModel) {
        ////

        this.notificationService.removeNotification(notification);

        this.notificationService.hideNofitications();
    }
}
