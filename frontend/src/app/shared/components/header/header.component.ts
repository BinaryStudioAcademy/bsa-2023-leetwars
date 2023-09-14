import { Component, OnDestroy, OnInit } from '@angular/core';
import { NotificationHubService } from '@core/hubs/notifications-hub.service';
import { AuthService } from '@core/services/auth.service';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { INotificationModel } from '@shared/models/notifications/notifications';
import { IUser } from '@shared/models/user/user';

import { NotificationsComponent } from '../notifications/notifications.component';

@Component({
    selector: 'app-header',
    templateUrl: './header.component.html',
    styleUrls: ['./header.component.sass'],
})
export class HeaderComponent implements OnInit, OnDestroy {
    constructor(private modalService: NgbModal, private authService: AuthService, private notificationHub: NotificationHubService) {
        this.authService.getUser().subscribe((user) => {
            this.user = user;
        });
    }

    user: IUser;

    showMenu: boolean = false;

    private notifications: INotificationModel[] = [];

    async ngOnInit() {
        await this.notificationHub.start();
        this.listeningHub();
    }

    showNotifications() {
        const modalRef = this.modalService.open(NotificationsComponent);

        modalRef.componentInstance.notifications = this.notifications;

        modalRef.hidden.subscribe(() => {
            this.notifications = [];
        });
    }

    get countNotification() {
        return this.notifications.length;
    }

    private listeningHub() {
        this.notificationHub.listenMessages((msg: INotificationModel) => {
            this.notifications.push(msg);
        });
    }

    ngOnDestroy() {
        this.notificationHub.stop();
    }
}
