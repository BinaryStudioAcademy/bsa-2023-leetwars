import { Injectable } from '@angular/core';
import { AuthService } from '@core/services/auth.service';
import { HubConnection } from '@microsoft/signalr';
import { ICodeRunResults } from '@shared/models/code-run/code-run-result';
import { ICodeSubmitResult } from '@shared/models/code-run/code-submit-result';
import { Subject } from 'rxjs';

import { SignalRHubFactoryService } from './signalr-hub-factory.service';

@Injectable({
    providedIn: 'root',
})
export class CodeDisplayingHubService {
    singleUserGroupId: string;

    private readonly hubUrl = 'codeDisplayingHub';

    private hubConnection: HubConnection;

    private codeRunResultsSubject$ = new Subject<ICodeRunResults>();

    private codeSubmitResultsSubject$ = new Subject<ICodeSubmitResult>();

    public codeRunResult$ = this.codeRunResultsSubject$.asObservable();

    public codeSubmitResults$ = this.codeSubmitResultsSubject$.asObservable();

    constructor(private hubFactory: SignalRHubFactoryService, private authService: AuthService) {}

    async start() {
        this.hubConnection = this.hubFactory.createHub(this.hubUrl);
        await this.init();
    }

    async stop() {
        await this.hubConnection?.stop();
    }

    private async init() {
        await this.hubConnection
            .start()
            .then(() => console.info(`"${this.hubFactory}" successfully started.`))
            .catch(() => console.info(`"${this.hubFactory}" failed.`));

        this.hubConnection.on('BroadcastMessageAsync', (msg: ICodeRunResults) => {
            this.codeRunResultsSubject$.next(msg);
        });

        this.hubConnection.on('BroadcastSubmitResultMessage', (msg: ICodeSubmitResult) => {
            this.codeSubmitResultsSubject$.next(msg);
        });

        await this.hubConnection.invoke('OnConnectAsync', `${this.authService.userSubject.value?.id}`);
    }
}
