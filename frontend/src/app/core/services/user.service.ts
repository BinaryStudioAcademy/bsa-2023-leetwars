import { Injectable } from '@angular/core';
import { IUserFull } from '@shared/models/profile/user-full';
import { INewUser } from '@shared/models/user/new-user';
import { IUser } from '@shared/models/user/user';
import { IUserSolutionsGroupedBySkillLevel } from '@shared/models/user/user-solutions-groupedby-skill-level';
import { Observable } from 'rxjs';

import { HttpInternalService } from './http-internal.service';

@Injectable({
    providedIn: 'root',
})
export class UserService {
    constructor(private httpService: HttpInternalService) {}

    public createUser(newUser: INewUser): Observable<IUser> {
        return this.httpService.postRequest<IUser>('/users', newUser);
    }

    public getCurrentUser(): Observable<IUser> {
        return this.httpService.getRequest<IUser>('/users/current');
    }

    public checkEmail(email: string): Observable<boolean> {
        return this.httpService.getRequest<boolean>(`/users/is-existing-email?email=${email}`);
    }

    public checkUserName(userName: string): Observable<boolean> {
        return this.httpService.getRequest<boolean>(`/users/is-existing-username?username=${userName}`);
    }

    public getFullUser(id: number): Observable<IUserFull> {
        return this.httpService.getRequest<IUserFull>(`/users/${id}`);
    }

    public getUserChallengesInfoByTags(id: number): Observable<IUserSolutionsGroupedBySkillLevel[]> {
        return this.httpService.getRequest<IUserSolutionsGroupedBySkillLevel[]>(`/users/${id}/user-challenges`);
    }
}
