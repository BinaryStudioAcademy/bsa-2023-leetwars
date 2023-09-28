import { Component, Input, OnInit } from '@angular/core';
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

    constructor(private notificationService: NotificationService) {}

    ngOnInit(): void {
        this.notificationService.currentNotifications.subscribe((notifications: INotificationModel[]) => {
            this.notifications = notifications;
        });
    }
}
