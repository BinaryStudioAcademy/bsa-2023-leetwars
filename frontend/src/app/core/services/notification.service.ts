import { Injectable } from '@angular/core';
import { NgbModal, NgbModalRef } from '@ng-bootstrap/ng-bootstrap';
import { NotificationsComponent } from '@shared/components/notifications/notifications.component';
import { INotificationModel } from '@shared/models/notifications/notifications';
import { BehaviorSubject } from 'rxjs';

@Injectable({
    providedIn: 'root',
})
export class NotificationService {
    private notifications: INotificationModel[] = [];

    private notificationModal: NgbModalRef;

    private notificationSubject = new BehaviorSubject(this.notifications);

    public currentNotifications = this.notificationSubject.asObservable();

    constructor(private modalService: NgbModal) {}

    public addNotification(notification: INotificationModel) {
        this.notifications = [...this.notifications, notification];

        this.notificationSubject.next(this.notifications);
    }

    public removeNotification(notification: INotificationModel) {
        this.notifications = this.notifications.filter((n) => n !== notification);

        this.notificationSubject.next(this.notifications);
    }

    public showNotifications() {
        this.notificationModal = this.modalService.open(NotificationsComponent);

        this.notificationModal.componentInstance.notifications = this.notifications;

        this.notificationModal.hidden.subscribe(() => {
            this.notifications = [];
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
