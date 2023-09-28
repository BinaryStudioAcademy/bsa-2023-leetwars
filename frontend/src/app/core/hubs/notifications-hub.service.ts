import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { AuthService } from '@core/services/auth.service';
import { CodeFightService } from '@core/services/code-fight.service';
import { EventService } from '@core/services/event.service';
import { NotificationService } from '@core/services/notification.service';
import { ToastrNotificationsService } from '@core/services/toastr-notifications.service';
import { UserService } from '@core/services/user.service';
import { HubConnection } from '@microsoft/signalr';
import { TypeNotification } from '@shared/enums/type-notification';
import { ICodeFightRequestNotification } from '@shared/models/codefight/code-fight-request-notification';
import { ICodeFightStart } from '@shared/models/codefight/code-fight-start';
import { IFriendshipPreview } from '@shared/models/friendship/friendship-preview';
import { INotificationModel } from '@shared/models/notifications/notifications';
import { IUser } from '@shared/models/user/user';
import { forkJoin, Subject, Subscription, timer } from 'rxjs';

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

    private user: IUser;

    private sender: IUser;

    private receiver: IUser;

    constructor(
        private hubFactory: SignalRHubFactoryService,
        private authservice: AuthService,
        private userService: UserService,
        private codeFightService: CodeFightService,
        private eventService: EventService,
        private notificationService: NotificationService,
        private toastrService: ToastrNotificationsService,
        private router: Router,
    ) {
        this.authservice.getUser().subscribe((user: IUser) => {
            this.user = user;
        });
    }

    async start() {
        this.hubConnection = this.hubFactory.createHub(this.hubUrl);
        await this.init();
    }

    listenMessages(action: (msg: INotificationModel) => void) {
        this.subscriptions = [...this.subscriptions, this.messages.subscribe({ next: action })];
    }

    async stop() {
        await this.hubConnection?.stop();
        this.subscriptions.forEach((s) => s.unsubscribe());
    }

    getConnectionId() {
        return this.hubConnectionId;
    }

    private async init() {
        await this.hubConnection
            .start()
            .then(() => console.info(`"${this.hubFactory}" successfully started.`))
            .catch(() => console.info(`"${this.hubFactory}" failed.`));

        this.hubConnection.on('SendNotificationAsync', (msg: INotificationModel) => {
            if (msg.showFor) {
                timer(msg.showFor).subscribe(() => {
                    this.notificationService.removeNotification(msg);
                });
            }

            this.messages.next(msg);
        });

        this.hubConnection.on('CodeFightRequestAsync', (codeFightRequest: ICodeFightRequestNotification) => {
            if (
                codeFightRequest.notification.typeNotification === TypeNotification.CodeFightRequestStart &&
                codeFightRequest.notification.showFor
            ) {
                timer(codeFightRequest.notification.showFor).subscribe(() => {
                    this.updateUsersAfterRequestEnded(codeFightRequest.notification);
                });
            }

            this.updateUsersAfterRequestStarted(codeFightRequest);
        });

        this.hubConnection.on('StartCodeFightAsync', (codeFight: ICodeFightStart) => {
            this.toastrService.showSuccess('Your code fight is about to start! Get ready!');
            this.router.navigateByUrl(`/challenges/codefight/${codeFight.challengeId}`);

            this.updateUsersAfterRequestEnded(codeFight.notification);
        });

        this.hubConnection.on('WinCodeFightAsync', () => {
            this.toastrService.showSuccess('You have won the code fight!');
            this.router.navigateByUrl('/leader/board', { state: { canLeave: true } });
        });

        this.hubConnection.on('LoseCodeFightAsync', () => {
            this.toastrService.showInfo('You have lost the code fight!');
            this.router.navigateByUrl('/leader/board', { state: { canLeave: true } });
        });

        this.hubConnection.on('UpdateFriendshipAsync', (notification: IFriendshipPreview) => {
            this.eventService.userFriendshipChanged(notification);
        });

        await this.hubConnection.invoke('OnConnectAsync', `${this.user.id.toString()}`);
    }

    private updateUsersAfterRequestStarted(codeFightRequest: ICodeFightRequestNotification) {
        const senderObservable = this.userService.getUser(codeFightRequest.senderId);
        const receiverObservable = this.userService.getUser(codeFightRequest.receiverId);

        forkJoin([senderObservable, receiverObservable]).subscribe(([senderUser, receiverUser]: [IUser, IUser]) => {
            this.sender = senderUser;
            this.receiver = receiverUser;

            this.eventService.usersStatusesChanged([this.sender, this.receiver]);
        });
    }

    private updateUsersAfterRequestEnded(notification: INotificationModel) {
        this.codeFightService.sendCodeFightRequestEnded(notification).subscribe((users: IUser[]) => {
            this.eventService.usersStatusesChanged(users);
        });
    }
}
