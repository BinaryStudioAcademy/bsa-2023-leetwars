import { HttpClient, HttpResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from '@env/environment';
import { FakeUser } from '@shared/models/fake-user';
import { BehaviorSubject, map, Observable } from 'rxjs';

@Injectable({
    providedIn: 'root',
})
// TODO: change FakeUser with real entity
export class AuthService {
    private userSubject: BehaviorSubject<FakeUser | undefined>;

    private user: FakeUser | undefined;

    private userNameInLS = 'userInfo';

    constructor(private httpClient: HttpClient) {
        // do nothing
    }

    public isAuthorized() {
        return this.user !== undefined && this.getUserInfo() !== undefined;
    }

    // TODO: change parameters to DTO
    public login(email: string, password: string) {
        return this.handleAuthResponse(
            this.httpClient.post<FakeUser>(
                `${environment.coreUrl}/signin`,
                { email, password },
                { observe: 'response' },
            ),
        );
    }

    // TODO: change parameters to DTO
    public register(username: string, email: string, password: string) {
        return this.handleAuthResponse(
            this.httpClient.post<FakeUser>(
                `${environment.coreUrl}/signup`,
                { username, email, password },
                { observe: 'response' },
            ),
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

    private handleAuthResponse(authObservable: Observable<HttpResponse<FakeUser>>): Observable<FakeUser> {
        return authObservable.pipe(
            map((resp) => {
                const user = resp.body as FakeUser;

                localStorage.setItem(this.userNameInLS, JSON.stringify(user));
                this.userSubject.next(user);
                this.user = user;

                return user;
            }),
        );
    }
}
