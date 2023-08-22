import { Component, OnDestroy, OnInit } from '@angular/core';
import { BroadcastHubService } from '@core/hubs/broadcast-hub.service';

@Component({
    selector: 'app-home',
    templateUrl: './main-page.component.html',
    styleUrls: ['./main-page.component.sass'],
})
export class MainComponent implements OnInit, OnDestroy {
    //TODO: Replace with real implementation
    public challengesList = ['nothing', 'to', 'be'];

    constructor(private broadcastHub: BroadcastHubService) {}

    async ngOnInit() {
        await this.broadcastHub.start();
        this.broadcastHub.listenMessages((msg) => {
            console.info(`The next broadcast message was received: ${msg}`);
        });
    }

    ngOnDestroy() {
        this.broadcastHub.stop();
    }
}
