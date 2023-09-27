import { Injectable } from '@angular/core';
import { HubConnection } from '@microsoft/signalr';
import { ICodeRunResults } from '@shared/models/code-run/code-run-result';
import { ICodeSubmitResult } from '@shared/models/code-run/code-submit-result';
import { Guid } from 'guid-typescript';
import { Subject } from 'rxjs';

import { SignalRHubFactoryService } from './signalr-hub-factory.service';

@Injectable({
    providedIn: 'root',
})
export class CodeDisplayingHubService {
    readonly hubUrl = 'codeDisplayingHub';

    private hubConnection: HubConnection;

    private codeRunResultsSubject$ = new Subject<ICodeRunResults>();

    private codeSubmitResultsSubject$ = new Subject<ICodeSubmitResult>();

    public codeRunResult$ = this.codeRunResultsSubject$.asObservable();

    public codeSubmitResults$ = this.codeSubmitResultsSubject$.asObservable();

    public singleUserGroupId: string;

    constructor(private hubFactory: SignalRHubFactoryService) {}

    async start() {
        this.hubConnection = this.hubFactory.createHub(this.hubUrl);
        this.singleUserGroupId = Guid.create().toString();
        await this.init();
    }

    async stop() {
        await this.hubConnection?.stop();
    }

    private async init() {
        await this.hubConnection
            .start()
            .then(() => console.info(`"${this.hubFactory}" successfully started.`))
            .then(() => this.registerUser())
            .catch(() => console.info(`"${this.hubFactory}" failed.`));

        this.hubConnection.on('BroadcastMessage', (msg: string) => {
            this.codeRunResultsSubject$.next(JSON.parse(msg) as ICodeRunResults);
        });

        this.hubConnection.on('BroadcastSubmitResultMessage', (msg: string) => {
            this.codeSubmitResultsSubject$.next(JSON.parse(msg) as ICodeSubmitResult);
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
