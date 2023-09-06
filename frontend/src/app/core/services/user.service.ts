import { Injectable } from '@angular/core';
import { UserFull } from '@shared/models/profile/user-full';
import { NewUser } from '@shared/models/user/new-user';
import { User } from '@shared/models/user/user';
import { Observable } from 'rxjs';

import { HttpInternalService } from './http-internal.service';
import { UserSolutionsGroupedBySkillLevelDto } from '@shared/models/user/user-solutions-groupedby-skill-level-dto';

@Injectable({
    providedIn: 'root',
})
export class UserService {
    constructor(private httpService: HttpInternalService) {}

    public createUser(newUser: NewUser): Observable<User> {
        return this.httpService.postRequest<User>('/users', newUser);
    }

    public getCurrentUser(): Observable<User> {
        return this.httpService.getRequest<User>('/users/current');
    }

    public checkEmail(email: string): Observable<boolean> {
        return this.httpService.getRequest<boolean>(`/users/is-existing-email?email=${email}`);
    }

    public checkUserName(userName: string): Observable<boolean> {
        return this.httpService.getRequest<boolean>(`/users/is-existing-username?username=${userName}`);
    }

    public getFullUser(id: number): Observable<UserFull> {
        return this.httpService.getRequest<UserFull>(`/users/${id}`);
    }

    public getUserChallengesInfoByTags(id:number): Observable<UserSolutionsGroupedBySkillLevelDto[]>
    {
        return this.httpService.getRequest<UserSolutionsGroupedBySkillLevelDto[]>(`/users/${id}/user-challenges`);
    }
}
