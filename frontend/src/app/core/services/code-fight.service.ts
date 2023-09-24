import { Injectable } from '@angular/core';
import { INotificationModel } from '@shared/models/notifications/notifications';

import { ChallengeService } from './challenge.service';

@Injectable({
    providedIn: 'root',
})
export class CodeFightService {
    constructor(private challengeService: ChallengeService) {}

    public startCodeFight(notification: INotificationModel) {
        return this.challengeService.sendCodeFightStart(notification);
    }
}
