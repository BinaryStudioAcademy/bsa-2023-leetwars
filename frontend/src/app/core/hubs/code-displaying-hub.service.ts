import { Injectable } from '@angular/core';
import { HubConnection } from '@microsoft/signalr';
import { map, Subject, Subscription } from 'rxjs';

import { SignalRHubFactoryService } from './signalr-hub-factory.service';

@Injectable({
    providedIn: 'root',
})
export class CodeDisplayingHubService {
    readonly hubUrl = 'codeDisplayingHub';

    private hubConnection: HubConnection;

    readonly messages = new Subject<string>();

    private subscriptions: Subscription[] = [];

    public connectionId: string;

    constructor(private hubFactory: SignalRHubFactoryService) {}

    async start() {
        this.hubConnection = this.hubFactory.createHub(this.hubUrl);
        await this.init();
    }

    listenMessages(action: (msg: string) => void) {
        const mappedObservable = this.messages.pipe(
            map((message: string) => {
                action(message);

                return message;
            }),
        );

        this.subscriptions.push(mappedObservable.subscribe());
    }

    async stop() {
        await this.hubConnection?.stop();
        this.subscriptions.forEach((s) => s.unsubscribe());
    }

    private async init() {
        await this.hubConnection
            .start()
            .then(() => console.info(`"${this.hubFactory}" successfully started.`))
            .then(() => this.getConnectionId())
            .catch(() => console.info(`"${this.hubFactory}" failed.`));

        this.hubConnection.on('BroadcastMessage', (msg: string) => {
            this.messages.next(msg);
        });

        this.hubConnection.onreconnected(() => {
            this.getConnectionId();
        });
    }

    public getConnectionId = async () => {
        try {
            const connectionId = await this.hubConnection.invoke('GetConnectionId');

            this.connectionId = connectionId;
        } catch (error) {
            console.error('Error getting connection ID:', error);
        }
    };
}
