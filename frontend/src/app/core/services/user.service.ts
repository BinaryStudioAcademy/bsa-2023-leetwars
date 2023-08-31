import { Injectable } from '@angular/core';
import { NewUser } from '@shared/models/new-user';
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

    public checkEmail(email: string): Observable<boolean> {
        return this.httpService.getRequest<boolean>(`/users/is-existing-email?email=${email}`);
    }
}
