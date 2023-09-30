import { HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { IFriendshipPreview } from '@shared/models/friendship/friendship-preview';
import { INewFriendship } from '@shared/models/friendship/new-friendship';
import { IUpdateFriendship } from '@shared/models/friendship/update-friendship';
import { IPageSettings } from '@shared/models/page-settings';
import { IUserSolution } from '@shared/models/profile/user-solution';
import { IEditUser } from '@shared/models/user/edit-user';
import { IEditUserInfo } from '@shared/models/user/edit-user-info';
import { INewUser } from '@shared/models/user/new-user';
import { INewUserSolution } from '@shared/models/user/new-user-solution';
import { IUser } from '@shared/models/user/user';
import { IUserAvatar } from '@shared/models/user/user-avatar';
import { IUserFriendsInfo } from '@shared/models/user/user-friends-info';
import { IUserFull } from '@shared/models/user/user-full';
import { IUserSolutionsGroupedBySkillLevel } from '@shared/models/user/user-solutions-groupedby-skill-level';
import { INewUserPreferences } from '@shared/models/user-prefferences/new-user-preferences';
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

    getUser(id: number): Observable<IUser> {
        return this.httpService.getRequest<IUser>(`${this.baseUrl}/${id}`);
    }

    getFullUser(id: number): Observable<IUserFull> {
        return this.httpService.getRequest<IUserFull>(`${this.baseUrl}/full/${id}`);
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

    sendFriendshipRequest(newFriendship: INewFriendship): Observable<IUserFriendsInfo> {
        return this.httpService.postRequest<IUserFriendsInfo>(`${this.baseUrl}/send-friendship-request`, newFriendship);
    }

    updateFriendshipRequest(updateFriendship: IUpdateFriendship): Observable<IUserFriendsInfo> {
        return this.httpService.putRequest<IUserFriendsInfo>(
            `${this.baseUrl}/update-friendship-request`,
            updateFriendship,
        );
    }

    getUserFriendships(id: number): Observable<IUserFriendsInfo> {
        return this.httpService.getRequest<IUserFriendsInfo>(`${this.baseUrl}/user-friendships?userid=${id}`);
    }

    getOneUserFriend(newFriendship: INewFriendship): Observable<IFriendshipPreview> {
        return this.httpService.postRequest<IFriendshipPreview>(`${this.baseUrl}/get-one-friend`, newFriendship);
    }
    
    getUserPrefferences(): Observable<IUserPreferences> {
        return this.httpService.getRequest<IUserPreferences>(`${this.baseUrl}/preferences`);
    }

    setUserPrefferences(newPreferences: INewUserPreferences): Observable<IUserPreferences> {
        return this.httpService.postRequest<IUserPreferences>(`${this.baseUrl}/preferences`, newPreferences);
    }

    submitSolution(newSolution: INewUserSolution): Observable<IUserSolution> {
        return this.httpService.postRequest<IUserSolution>(`${this.baseUrl}/submit`, newSolution);
    }
}
