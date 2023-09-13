import { Component } from '@angular/core';
import { BroadcastHubService } from '@core/hubs/broadcast-hub.service';
import { AuthService } from '@core/services/auth.service';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { NotificationModel } from '@shared/models/notifications/notifications';
import { IUser } from '@shared/models/user/user';

import { NotificationsComponent } from '../notifications/notifications.component';

@Component({
    selector: 'app-header',
    templateUrl: './header.component.html',
    styleUrls: ['./header.component.sass'],
})
export class HeaderComponent {
    constructor(private modalService: NgbModal, private authService: AuthService, private broadcastHubService: BroadcastHubService) {
        this.authService.getUser().subscribe((user) => {
            this.user = user;
        });
        this.listeningHub();
    }

    user: IUser;

    showMenu: boolean = false;

    private notifications: NotificationModel[] = [];

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
        this.broadcastHubService.listenMessages((msg: string) => {
            const notification = JSON.parse(msg) as NotificationModel;

            this.notifications.push(notification);
        });
    }
}
