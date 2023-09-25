import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { AuthService } from '@core/services/auth.service';
import { NotificationService } from '@core/services/notification.service';
import { ToastrNotificationsService } from '@core/services/toastr-notifications.service';
import { HubConnection } from '@microsoft/signalr';
import { ICodeFightStart } from '@shared/models/codefight/code-fight-start';
import { INotificationModel } from '@shared/models/notifications/notifications';
import { Subject, Subscription, timer } from 'rxjs';

import { SignalRHubFactoryService } from './signalr-hub-factory.service';

@Injectable({
    providedIn: 'root',
})
export class NotificationHubService {
    readonly hubUrl = 'notificationHub';

    private hubConnection: HubConnection;

    readonly messages = new Subject<INotificationModel>();

    private subscriptions: Subscription[] = [];

    private hubConnectionId: string;

    constructor(
        private hubFactory: SignalRHubFactoryService,
        private authservice: AuthService,
        private notificationService: NotificationService,
        private toastrService: ToastrNotificationsService,
        private router: Router,
    ) {}

    async start() {
        this.hubConnection = this.hubFactory.createHub(this.hubUrl);
        await this.init();
    }

    listenMessages(action: (msg: INotificationModel) => void) {
        this.subscriptions = [...this.subscriptions, this.messages.subscribe({ next: action })];
    }

    async stop() {
        await this.hubConnection?.stop();
        this.subscriptions.forEach((s) => s.unsubscribe());
    }

    public getConnectionId() {
        return this.hubConnectionId;
    }

    private async init() {
        await this.hubConnection
            .start()
            .then(() => console.info(`"${this.hubFactory}" successfully started.`))
            .catch(() => console.info(`"${this.hubFactory}" failed.`));

        this.hubConnection.on('SendNotificationAsync', (msg: INotificationModel) => {
            if (msg.showFor) {
                timer(msg.showFor).subscribe(() => {
                    this.notificationService.removeNotification(msg);
                });
            }

            this.messages.next(msg);
        });

        this.hubConnection.on('StartCodeFightAsync', (codeFight: ICodeFightStart) => {
            this.toastrService.showSuccess('Your code fight is about to start! Get ready!');
            this.router.navigateByUrl(`/challenges/codefight/${codeFight.challengeId}`);
        });

        this.hubConnection.on('WinCodeFightAsync', () => {
            this.toastrService.showSuccess('You have won the code fight!');
            this.router.navigateByUrl('/leader/board', { state: { canLeave: true } });
        });

        this.hubConnection.on('LoseCodeFightAsync', () => {
            this.toastrService.showWarning('You have lost the code fight!');
            this.router.navigateByUrl('/leader/board', { state: { canLeave: true } });
        });

        await this.hubConnection.invoke('OnConnectAsync', `${this.authservice.userSubject.value?.id}`);
    }
}
