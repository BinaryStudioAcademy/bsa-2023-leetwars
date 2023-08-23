import { Injectable, NgZone } from '@angular/core';
import { AngularFireAuth } from '@angular/fire/compat/auth';
import { FakeUser } from '@shared/models/fake-user';
import { GithubAuthProvider, GoogleAuthProvider } from 'firebase/auth';
import firebase from 'firebase/compat';
import { BehaviorSubject, first, from, Observable, switchMap, tap, throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';

import { HttpInternalService } from './http-internal.service';

@Injectable({
    providedIn: 'root',
})
// TODO: change FakeUser with real entity
export class AuthService {
    private userSubject: BehaviorSubject<FakeUser | undefined>;

    private user: FakeUser | undefined;

    private userKeyName = 'userInfo';

    private tokenKeyName = 'userToken';

    constructor(private httpService: HttpInternalService, private afAuth: AngularFireAuth, private ngZone: NgZone) {
        afAuth.authState.subscribe(async (user) => {
            if (user) {
                localStorage.setItem(this.tokenKeyName, await user.getIdToken());
            } else {
                localStorage.removeItem(this.tokenKeyName);
            }
        });
    }

    public isAuthorized() {
        return this.user && this.getUserInfo();
    }

    // TODO: change parameters to DTO
    public register(username: string, email: string, password: string) {
        return from(this.afAuth.createUserWithEmailAndPassword(email, password)).pipe(
            first(),
            tap(() => this.sendVerificationMail()),
            catchError(error => throwError(error.message)),
            switchMap(() =>
                this.httpService.postRequest<FakeUser>('/signup', { username, email, password })
                    .pipe(first(), tap(user => this.setUserInfo(user)))),

        );
    }

    // TODO: change parameters to DTO
    public login(email: string, password: string) {
        return from(this.afAuth.signInWithEmailAndPassword(email, password)).pipe(
            first(),
            catchError(error => throwError(error.message)),
            switchMap(() =>
                this.httpService.postRequest<FakeUser>('/signin', { email, password })
                    .pipe(first(), tap(user => this.setUserInfo(user)))),
        );
    }

    public logout() {
        this.removeUserInfo();
        this.user = undefined;
        this.userSubject.next(undefined);

        return from(this.afAuth.signOut());
    }

    public getUserToken(): string | null {
        return localStorage.getItem(this.tokenKeyName);
    }

    // TODO: Implemented only firebase part
    public signInWithGoogle() {
        return this.signInWithProvider(new GoogleAuthProvider());
    }

    // TODO: Implemented only firebase part
    public signInWithGitHub() {
        return this.signInWithProvider(new GithubAuthProvider());
    }

    // TODO: Implemented only firebase part
    public changePassword(password: string): Observable<void> {
        return from(this.afAuth.currentUser).pipe(
            first(),
            switchMap((user) => {
                if (user) {
                    return user.updatePassword(password);
                }

                throw new Error('User is not authorized');
            }),
        ).pipe(first());
    }

    public sendVerificationMail(): Observable<void> {
        return from(this.afAuth.currentUser).pipe(
            first(),
            switchMap((user) => {
                if (user) {
                    return user.sendEmailVerification();
                }

                throw new Error('User is not authorized');
            }),
        ).pipe(first());
    }

    // TODO: Implemented only firebase part
    public forgotPassword(passwordResetEmail: string): Observable<void> {
        return from(this.afAuth.sendPasswordResetEmail(passwordResetEmail)).pipe(first());
    }

    private signInWithProvider(provider: firebase.auth.AuthProvider) {
        return from(this.afAuth.signInWithPopup(provider))
            .pipe(
                first(),
                catchError(error => throwError(error.message)),
            );
    }

    private getUserInfo(): FakeUser | undefined {
        const userInfo = localStorage.getItem(this.userKeyName);

        if (userInfo) {
            return JSON.parse(userInfo);
        }

        return undefined;
    }

    private setUserInfo(user: FakeUser) {
        localStorage.setItem(this.userKeyName, JSON.stringify(user));
        this.userSubject.next(user);
        this.user = user;
    }

    private removeUserInfo() {
        localStorage.removeItem(this.userKeyName);
    }
}
