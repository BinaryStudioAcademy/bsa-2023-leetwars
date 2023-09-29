import { HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { INotificationModel } from '@shared/models/notifications/notifications';
import { IPageSettings } from '@shared/models/page-settings';
import { setParams } from '@shared/utils/http-params.utils';

import { HttpInternalService } from './http-internal.service';

@Injectable({
    providedIn: 'root',
})
export class NotificationStorageService {
    private baseUrl = '/notifications';

    constructor(private httpService: HttpInternalService) {}

    public getUserNotifications(page: IPageSettings) {
        let httpParams = new HttpParams();

        httpParams = setParams<IPageSettings>(httpParams, page);

        return this.httpService.getRequest<INotificationModel[]>(`${this.baseUrl}`, httpParams);
    }

    public updateStatusToRead(ids: number[]) {
        return this.httpService.putRequest(`${this.baseUrl}`, ids);
    }

    public getUnreadNotificationsCount() {
        return this.httpService.getRequest<number>(`${this.baseUrl}/unreadCount`);
    }
}
