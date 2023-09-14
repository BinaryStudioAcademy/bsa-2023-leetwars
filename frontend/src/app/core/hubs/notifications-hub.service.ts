import { Injectable } from '@angular/core';
import { HubConnection } from '@microsoft/signalr';
import { INotificationModel } from '@shared/models/notifications/notifications';
import { Subject, Subscription } from 'rxjs';

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

    constructor(private hubFactory: SignalRHubFactoryService) {}

    async start() {
        this.hubConnection = this.hubFactory.createHub(this.hubUrl);
        await this.init();
    }

    listenMessages(action: (msg: INotificationModel) => void) {
        this.subscriptions.push(this.messages.subscribe({ next: action }));
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

        this.hubConnection.on('SendNotification', (msg: INotificationModel) => {
            this.messages.next(msg);
        });

        this.hubConnection.invoke('GetConnectionId')
            .then((id) => {
                this.hubConnectionId = id;
            })
            .catch((err) => {
                console.error(err);
            });
    }
}
