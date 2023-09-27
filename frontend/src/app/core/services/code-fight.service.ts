import { Injectable } from '@angular/core';
import { ICodeFightEnd } from '@shared/models/codefight/code-fight-end';
import { ICodeFightRequest } from '@shared/models/codefight/code-fight-request';
import { INotificationModel } from '@shared/models/notifications/notifications';
import { IUser } from '@shared/models/user/user';
import { Observable } from 'rxjs';

import { HttpInternalService } from './http-internal.service';

@Injectable({
    providedIn: 'root',
})
export class CodeFightService {
    private codeFightRoute = '/codeFight';

    constructor(private httpService: HttpInternalService) {}

    sendCodeFightRequestStarted(codeFight: ICodeFightRequest): Observable<IUser[]> {
        return this.httpService.postRequest<IUser[]>(`${this.codeFightRoute}/codeFightRequestStarted`, codeFight);
    }

    sendCodeFightRequestEnded(notification: INotificationModel): Observable<IUser[]> {
        return this.httpService.postRequest<IUser[]>(`${this.codeFightRoute}/codeFightRequestEnded`, notification);
    }

    sendCodeFightStart(notification: INotificationModel): Observable<IUser[]> {
        return this.httpService.postRequest<IUser[]>(`${this.codeFightRoute}/codefightstart`, notification);
    }

    sendCodeFightEnd(codeFightEnd: ICodeFightEnd): Observable<IUser[]> {
        return this.httpService.postRequest<IUser[]>(`${this.codeFightRoute}/codefightend`, codeFightEnd);
    }
}
