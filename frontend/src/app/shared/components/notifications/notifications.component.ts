import { Component, Input } from '@angular/core';
import { BaseComponent } from '@core/base/base.component';
import { longFadeIn } from '@shared/animations/long-fade-in.animation';
import { TypeNotification } from '@shared/enums/type-notification';
import { INotificationModel } from '@shared/models/notifications/notifications';

@Component({
    selector: 'app-notifications',
    templateUrl: './notifications.component.html',
    styleUrls: ['./notifications.component.sass'],
    animations: [longFadeIn],
})
export class NotificationsComponent extends BaseComponent {
    @Input() notifications: INotificationModel[];

    @Input() isUnread: boolean;

    trackByFn(index: number, item: INotificationModel) {
        return item.dateSending;
    }

    typeNotification = TypeNotification;
}
