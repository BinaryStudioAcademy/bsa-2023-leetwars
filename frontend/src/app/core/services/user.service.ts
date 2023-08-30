import { Injectable } from '@angular/core';
import { NewUser } from '@shared/models/new-user';
import { UserFull } from '@shared/models/profile/user-full';
import { User } from '@shared/models/user';
import { Observable } from 'rxjs';

import { HttpInternalService } from './http-internal.service';

@Injectable({
    providedIn: 'root',
})
export class UserService {
    constructor(private httpService: HttpInternalService) {}

    public createUser(newUser: NewUser): Observable<User> {
        return this.httpService.postRequest<User>('/users', newUser);
    }

    public getFullUser(id: number): Observable<UserFull> {
        return this.httpService.getRequest<UserFull>(`/users/${id}`);
    }
}
