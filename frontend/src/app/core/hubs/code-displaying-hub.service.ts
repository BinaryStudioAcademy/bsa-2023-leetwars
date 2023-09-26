import { Injectable } from '@angular/core';
import { AuthService } from '@core/services/auth.service';
import { HubConnection } from '@microsoft/signalr';
import { ICodeRunResults } from '@shared/models/code-run/code-run-result';
import { Guid } from 'guid-typescript';
import { Subject, Subscription } from 'rxjs';

import { SignalRHubFactoryService } from './signalr-hub-factory.service';

@Injectable({
    providedIn: 'root',
})
export class CodeDisplayingHubService {
    singleUserGroupId: string;

    private readonly hubUrl = 'codeDisplayingHub';

    private hubConnection: HubConnection;

    private readonly messages = new Subject<ICodeRunResults>();

    private subscriptions: Subscription[] = [];

    constructor(private hubFactory: SignalRHubFactoryService, private authService: AuthService) {}

    async start() {
        this.hubConnection = this.hubFactory.createHub(this.hubUrl);
        this.singleUserGroupId = Guid.create().toString();
        await this.init();
    }

    listenMessages(action: (msg: ICodeRunResults) => void) {
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
            .catch(() => console.info(`"${this.hubFactory}" failed.`));

        this.hubConnection.on('BroadcastMessageAsync', (msg: ICodeRunResults) => {
            this.messages.next(msg);
        });

        await this.hubConnection.invoke('OnConnectAsync', `${this.authService.userSubject.value?.id}`);
    }
}
