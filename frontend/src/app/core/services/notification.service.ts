import { Injectable } from '@angular/core';
import { INotificationModel } from '@shared/models/notifications/notifications';
import { BehaviorSubject } from 'rxjs';

@Injectable({
    providedIn: 'root',
})
export class NotificationService {
    notifications: INotificationModel[] = [];

    notificationSubject = new BehaviorSubject(this.notifications);

    currentNotifications = this.notificationSubject.asObservable();

    addNotification(notification: INotificationModel) {
        this.notifications = [...this.notifications, notification];

        this.notificationSubject.next(this.notifications);
    }

    removeNotification(notification: INotificationModel) {
        this.notifications = this.notifications.filter((n) => n !== notification);

        this.notificationSubject.next(this.notifications);
    }

    get countNotification() {
        return this.notifications.length;
    }
}
