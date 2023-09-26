import { Injectable } from '@angular/core';
import { INewUserPreferences } from '@shared/models/user-prefferences/new-user-preferences';
import { IUserPreferences } from '@shared/models/user-prefferences/user-preferences';
import { Observable } from 'rxjs';

import { HttpInternalService } from './http-internal.service';

@Injectable({
    providedIn: 'root',
})
export class PreferencesService {
    private readonly baseUrl: string = '/preferences';

    constructor(private httpService: HttpInternalService) {}

    public getUserPrefferences(): Observable<IUserPreferences> {
        return this.httpService.getRequest<IUserPreferences>(`${this.baseUrl}`);
    }

    public setUserPrefferences(newPreferences: INewUserPreferences): Observable<IUserPreferences> {
        return this.httpService.postRequest<IUserPreferences>(`${this.baseUrl}`, newPreferences);
    }
}
