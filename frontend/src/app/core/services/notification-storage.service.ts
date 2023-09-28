import { Injectable } from '@angular/core';
import { INotificationModel } from '@shared/models/notifications/notifications';

import { HttpInternalService } from './http-internal.service';

@Injectable({
    providedIn: 'root',
})
export class NotificationStorageService {
    private baseUrl = '/notifications';

    constructor(private httpService: HttpInternalService) {}

    public getUserNotifications() {
        return this.httpService.getRequest<INotificationModel[]>(`${this.baseUrl}`);
    }

    public updateStatusToRead(ids: number[]) {
        return this.httpService.putRequest(`${this.baseUrl}`, ids);
    }
}
