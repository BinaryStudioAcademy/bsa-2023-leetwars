import { Injectable } from '@angular/core';
import { HubConnection } from '@microsoft/signalr';
import { Subject, Subscription } from 'rxjs';

import { SignalRHubFactoryService } from './signalr-hub-factory.service';

@Injectable({
    providedIn: 'root',
})
export class BroadcastHubService {
    readonly hubUrl = 'broadcastHub';

    private hubConnection: HubConnection;

    private hubConnectionId: string;

    readonly messages = new Subject<string>();

    private subscriptions: Subscription[] = [];

    constructor(private hubFactory: SignalRHubFactoryService) {}

    async start() {
        this.hubConnection = this.hubFactory.createHub(this.hubUrl);

        await this.init();
    }

    public getConnectionId() {
        return this.hubConnectionId;
    }

    listenMessages(action: (msg: string) => void) {
        this.subscriptions.push(this.messages.subscribe({ next: action }));
    }

    async stop() {
        await this.hubConnection?.stop();
        this.subscriptions.forEach((s) => s.unsubscribe());
    }

    private async init() {
        await this.hubConnection
            .start()
            .then(() => console.info(`"${this.hubFactory}" successfully started.`))
            .catch(() => console.info(`"${this.hubFactory}" failed.`));

        this.hubConnection.on('BroadcastMessage', (msg: string) => {
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
