import { HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { IPageSettings } from '@shared/models/page-settings';
import { IEditUser } from '@shared/models/user/edit-user';
import { IEditUserInfo } from '@shared/models/user/edit-user-info';
import { INewUser } from '@shared/models/user/new-user';
import { IUser } from '@shared/models/user/user';
import { IUserAvatar } from '@shared/models/user/user-avatar';
import { IUserFull } from '@shared/models/user/user-full';
import { IUserSolutionsGroupedBySkillLevel } from '@shared/models/user/user-solutions-groupedby-skill-level';
import { IUserPreferences } from '@shared/models/user-prefferences/user-preferences';
import { setParams } from '@shared/utils/http-params.utils';
import { Observable } from 'rxjs';

import { HttpInternalService } from './http-internal.service';

@Injectable({
    providedIn: 'root',
})
export class UserService {
    private readonly baseUrl: string = '/users';

    constructor(private httpService: HttpInternalService) {}

    createUser(newUser: INewUser): Observable<IUser> {
        return this.httpService.postRequest<IUser>(`${this.baseUrl}`, newUser);
    }

    getCurrentUser(): Observable<IUser> {
        return this.httpService.getRequest<IUser>(`${this.baseUrl}/current`);
    }

    checkEmail(email: string): Observable<boolean> {
        return this.httpService.getRequest<boolean>(`${this.baseUrl}/is-existing-email?email=${email}`);
    }

    checkUserName(userName: string): Observable<boolean> {
        return this.httpService.getRequest<boolean>(`${this.baseUrl}/is-existing-username?username=${userName}`);
    }

    getFullUser(id: number): Observable<IUserFull> {
        return this.httpService.getRequest<IUserFull>(`${this.baseUrl}/${id}`);
    }

    updateUser(editUserInfo: IEditUserInfo): Observable<IUser> {
        return this.httpService.putRequest<IUser>(`${this.baseUrl}`, editUserInfo);
    }

    updateUserAvatar(fileFormData: FormData): Observable<IUserAvatar> {
        return this.httpService.postRequest<IUserAvatar>(`${this.baseUrl}/avatar`, fileFormData);
    }

    getUserChallengesInfoByTags(id: number): Observable<IUserSolutionsGroupedBySkillLevel[]> {
        return this.httpService.getRequest<IUserSolutionsGroupedBySkillLevel[]>(
            `${this.baseUrl}/${id}/user-challenges`,
        );
    }

    getLeaderBoard(page?: IPageSettings): Observable<IUser[]> {
        let httpParams = new HttpParams();

        httpParams = setParams<IPageSettings>(httpParams, page);

        return this.httpService.getRequest<IUser[]>(`${this.baseUrl}/leader-board`, httpParams);
    }

    updateUserRank(userDto: IEditUser): Observable<IUserFull> {
        return this.httpService.putRequest<IUserFull>(`${this.baseUrl}/rank`, userDto);
    }

    //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    public getUserPrefferences(): Observable<IUserPreferences> {
        return this.httpService.getRequest<IUserPreferences>(`${this.baseUrl}/prefferences`);
    }
}
