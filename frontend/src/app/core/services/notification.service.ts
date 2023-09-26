import { Injectable } from '@angular/core';
import { INotificationModel } from '@shared/models/notifications/notifications';

import { HttpInternalService } from './http-internal.service';

@Injectable({
    providedIn: 'root',
})
export class NotificationService {
    private baseUrl = '/notifications';

    constructor(private httpService: HttpInternalService) {}

    public getUserNotifications(id: number) {
        return this.httpService.getRequest<INotificationModel[]>(`${this.baseUrl}/${id}`);
    }

    public updateStatusToRead(ids: number[]) {
        return this.httpService.putRequest(`${this.baseUrl}`, ids);
    }
}
