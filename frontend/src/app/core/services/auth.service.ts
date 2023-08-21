import { Injectable } from '@angular/core';
import { FakeUser } from '@shared/models/fake-user';
import { BehaviorSubject, map, Observable } from 'rxjs';

import { HttpInternalService } from './http-internal.service';

@Injectable({
    providedIn: 'root',
})
// TODO: change FakeUser with real entity
export class AuthService {
    private userSubject: BehaviorSubject<FakeUser | undefined>;

    private user: FakeUser | undefined;

    private userNameInLS = 'userInfo';

    constructor(private httpService: HttpInternalService) {}

    public isAuthorized() {
        return this.user !== undefined && this.getUserInfo() !== undefined;
    }

    // TODO: change parameters to DTO
    public login(email: string, password: string) {
        return this.handleAuthResponse(this.httpService.postRequest<FakeUser>('/signin', { email, password }));
    }

    // TODO: change parameters to DTO
    public register(username: string, email: string, password: string) {
        return this.handleAuthResponse(
            this.httpService.postRequest<FakeUser>('/signup', { username, email, password }),
        );
    }

    public logout() {
        this.removeUserInfo();
        this.user = undefined;
        this.userSubject.next(undefined);
    }

    private getUserInfo(): FakeUser | undefined {
        const userInfo = localStorage.getItem(this.userNameInLS);

        if (userInfo) {
            return JSON.parse(userInfo);
        }

        return undefined;
    }

    private removeUserInfo() {
        localStorage.removeItem(this.userNameInLS);
    }

    private handleAuthResponse(authObservable: Observable<FakeUser>): Observable<FakeUser> {
        return authObservable.pipe(
            map((resp) => {
                const user = resp;

                localStorage.setItem(this.userNameInLS, JSON.stringify(user));
                this.userSubject.next(user);
                this.user = user;

                return user;
            }),
        );
    }
}
