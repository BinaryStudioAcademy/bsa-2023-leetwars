import { Injectable } from '@angular/core';
import { HubConnection } from '@microsoft/signalr';
import { Guid } from 'guid-typescript';
import { Subject, Subscription } from 'rxjs';

import { SignalRHubFactoryService } from './signalr-hub-factory.service';

@Injectable({
    providedIn: 'root',
})
export class CodeDisplayingHubService {
    readonly hubUrl = 'codeDisplayingHub';

    private hubConnection: HubConnection;

    readonly messages = new Subject<string>();

    private subscriptions: Subscription[] = [];

    public singleUserGroupId: string;

    constructor(private hubFactory: SignalRHubFactoryService) {}

    async start() {
        this.hubConnection = this.hubFactory.createHub(this.hubUrl);
        this.singleUserGroupId = Guid.create().toString();
        await this.init();
    }

    listenMessages(action: (msg: string) => void) {
        this.subscriptions = [...this.subscriptions, this.messages.subscribe({ next: action })];
    }

    async stop() {
        await this.hubConnection?.stop();
        this.subscriptions.forEach((s) => s.unsubscribe());
    }

    private async init() {
        await this.hubConnection
            .start()
            .then(() => console.info(`"${this.hubFactory}" successfully started.`))
            .then(() => this.registerUser())
            .catch(() => console.info(`"${this.hubFactory}" failed.`));

        this.hubConnection.on('BroadcastMessage', (msg: string) => {
            this.messages.next(msg);
        });

        this.hubConnection.onreconnected(() => {
            this.registerUser();
        });
    }

    public registerUser = async () => {
        try {
            await this.hubConnection.invoke('OnConnectAsync', `${this.singleUserGroupId}`);
        } catch (error) {
            console.error('Error getting connection ID:', error);
        }
    };
}
