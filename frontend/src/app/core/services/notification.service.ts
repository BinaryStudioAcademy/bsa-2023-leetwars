import { Injectable } from '@angular/core';
import { NgbModal, NgbModalRef } from '@ng-bootstrap/ng-bootstrap';
import { NotificationsComponent } from '@shared/components/notifications/notifications.component';
import { TypeNotification } from '@shared/enums/type-notification';
import { INotificationModel } from '@shared/models/notifications/notifications';

@Injectable({
    providedIn: 'root',
})
export class NotificationService {
    private notifications: INotificationModel[] = [];

    private notificationModal: NgbModalRef;

    constructor(private modalService: NgbModal) {}

    public addNotification(notification: INotificationModel) {
        this.notifications = [...this.notifications, notification];
    }

    public removeNotification(notification: INotificationModel) {
        this.notifications = this.notifications.filter((n) => n !== notification);
    }

    public showNotifications() {
        this.notificationModal = this.modalService.open(NotificationsComponent);

        this.notificationModal.componentInstance.notifications = this.notifications;

        this.notificationModal.hidden.subscribe(() => {
            this.notifications = this.notifications.filter((n) => n.typeNotification === TypeNotification.CodeFight);
        });

        this.notificationModal.closed.subscribe((nofitications: INotificationModel[]) => {
            this.notifications = nofitications;
        });
    }

    public hideNofitications() {
        this.notificationModal.close(this.notifications);
    }

    public get countNotification() {
        return this.notifications.length;
    }
}