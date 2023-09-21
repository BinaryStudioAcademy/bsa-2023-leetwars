import { Injectable } from '@angular/core';
import { TypeNotification } from '@shared/enums/type-notification';
import { INotificationModel } from '@shared/models/notifications/notifications';

import { ChallengeService } from './challenge.service';

@Injectable({
    providedIn: 'root',
})
export class CodeFightService {
    constructor(private challengeService: ChallengeService) {}

    public startCodeFight(notification: INotificationModel) {
        notification.typeNotification = TypeNotification.CodeFightRedirect;
        this.challengeService.sendCodeFightRedirect(notification).subscribe();
    }
}
