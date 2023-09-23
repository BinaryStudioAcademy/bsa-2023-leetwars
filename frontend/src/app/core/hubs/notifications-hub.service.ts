import { Injectable } from '@angular/core';
import { AuthService } from '@core/services/auth.service';
import { HubConnection } from '@microsoft/signalr';
import { INotificationModel } from '@shared/models/notifications/notifications';
import { Subject, Subscription } from 'rxjs';

import { SignalRHubFactoryService } from './signalr-hub-factory.service';

@Injectable({
    providedIn: 'root',
})
export class NotificationHubService {
    private readonly hubUrl = 'notificationHub';

    private hubConnection: HubConnection;

    private readonly messages = new Subject<INotificationModel>();

    private subscriptions: Subscription[] = [];

    private hubConnectionId: string;

    constructor(private hubFactory: SignalRHubFactoryService, private authservice: AuthService) {}

    public async start() {
        this.hubConnection = this.hubFactory.createHub(this.hubUrl);
        await this.init();
    }

    public listenMessages(action: (msg: INotificationModel) => void) {
        this.subscriptions = [...this.subscriptions, this.messages.subscribe({ next: action })];
    }

    public async stop() {
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
            this.messages.next(msg);
        });

        await this.hubConnection.invoke('OnConnectAsync', `${this.authservice.userSubject.value?.id}`);
    }
}
