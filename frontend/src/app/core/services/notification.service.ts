import { Injectable } from '@angular/core';
import { NgbModal, NgbModalRef } from '@ng-bootstrap/ng-bootstrap';
import { NotificationsComponent } from '@shared/components/notifications/notifications.component';
import { TypeNotification } from '@shared/enums/type-notification';
import { INotificationModel } from '@shared/models/notifications/notifications';
import { BehaviorSubject } from 'rxjs';

@Injectable({
    providedIn: 'root',
})
export class NotificationService {
    private notifications: INotificationModel[] = [];

    strongNotifications: TypeNotification[] = [TypeNotification.FriendRequest];

    notificationSubject = new BehaviorSubject(this.notifications);

    currentNotifications = this.notificationSubject.asObservable();

    private notificationModal: NgbModalRef;

    constructor(private modalService: NgbModal) {}

    addNotification(notification: INotificationModel) {
        this.notifications = [...this.notifications, notification];

        this.notificationSubject.next(this.notifications);
    }

    removeNotification(notification: INotificationModel) {
        this.notifications = this.notifications.filter((n) => n !== notification);

        this.notificationSubject.next(this.notifications);
    }

    showNotifications() {
        this.notificationModal = this.modalService.open(NotificationsComponent);

        this.notificationModal.componentInstance.notifications = this.notifications;

        this.notificationModal.hidden.subscribe(() => {
            this.filterCurrentNotifications(this.strongNotifications);
        });

        this.notificationModal.closed.subscribe((nofitications: INotificationModel[]) => {
            this.notifications = nofitications;
        });
    }

    hideNofitications() {
        this.notificationModal.close(this.notifications);
    }

    get countNotification() {
        return this.notifications.length;
    }

    private filterCurrentNotifications(notificationTypes: TypeNotification[]) {
        this.notifications = this.notifications.filter((n) => notificationTypes.includes(n.typeNotification));
    }
}
