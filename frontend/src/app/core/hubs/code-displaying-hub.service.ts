import { Injectable } from '@angular/core';
import { HubConnection } from '@microsoft/signalr';
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

    public connectionId: string;

    constructor(private hubFactory: SignalRHubFactoryService) {}

    async start() {
        this.hubConnection = this.hubFactory.createHub(this.hubUrl);
        await this.init();
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
            .then(() => this.getConnectionId())
            .catch(() => console.info(`"${this.hubFactory}" failed.`));

        this.hubConnection.on('BroadcastMessage', (msg: string) => {
            this.messages.next(msg);
        });
    }

    public getConnectionId = async () => {
        try {
          console.log("I am here!");
          const connectionId = await this.hubConnection.invoke('GetConnectionId');
          this.connectionId = connectionId;
          console.log('Connection ID:', connectionId);
        } catch (error) {
          console.error('Error getting connection ID:', error);
          // Handle the error as needed (e.g., show an error message, retry, etc.)
        }
      }
}
