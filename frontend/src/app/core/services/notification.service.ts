import { Injectable } from '@angular/core';
import { NgbModal, NgbModalRef } from '@ng-bootstrap/ng-bootstrap';
import { NotificationsComponent } from '@shared/components/notifications/notifications.component';
import { INotificationModel } from '@shared/models/notifications/notifications';

@Injectable({
    providedIn: 'root',
})
export class NotificationService {
    private notifications: INotificationModel[] = [];

    private notificationModal: NgbModalRef;

    constructor(private modalService: NgbModal) {}

    addNotification(notification: INotificationModel) {
        this.notifications = [...this.notifications, notification];
    }

    removeNotification(notification: INotificationModel) {
        this.notifications = this.notifications.filter((n) => n !== notification);
    }

    showNotifications() {
        this.notificationModal = this.modalService.open(NotificationsComponent);

        this.notificationModal.componentInstance.notifications = this.notifications;

        this.notificationModal.hidden.subscribe(() => {
            this.notifications = [];
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
}
