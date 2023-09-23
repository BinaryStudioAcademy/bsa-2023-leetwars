import { Component, Input } from '@angular/core';
import { BaseComponent } from '@core/base/base.component';
import { TypeNotification } from '@shared/enums/type-notification';
import { INotificationModel } from '@shared/models/notifications/notifications';

@Component({
    selector: 'app-notifications',
    templateUrl: './notifications.component.html',
    styleUrls: ['./notifications.component.sass'],
})
export class NotificationsComponent extends BaseComponent {
    @Input() notifications: INotificationModel[];

    public typeNotification = TypeNotification;
}
