import { Injectable } from '@angular/core';
import { AngularFireAuth } from '@angular/fire/compat/auth';
import { User } from '@shared/models/user/user';
import { UserLoginDto } from '@shared/models/user/user-login-dto';
import { UserRegisterDto } from '@shared/models/user/user-register-dto';
import { GithubAuthProvider, GoogleAuthProvider } from 'firebase/auth';
import firebase from 'firebase/compat';
import { BehaviorSubject, first, from, Observable, switchMap, tap, throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';

import { UserService } from './user.service';

@Injectable({
    providedIn: 'root',
})
export class AuthService {
    private userSubject: BehaviorSubject<User | undefined>;

    private user: User | undefined;

    private userKeyName = 'userInfo';

    private tokenKeyName = 'userToken';

    constructor(private afAuth: AngularFireAuth, private userService: UserService) {
        this.userSubject = new BehaviorSubject<User | undefined>(this.getUserInfo());
        afAuth.authState.subscribe(async (user) => {
            if (user) {
                localStorage.setItem(this.tokenKeyName, await user.getIdToken());
            } else {
                localStorage.removeItem(this.tokenKeyName);
            }
        });
    }

    public isAuthorized() {
        return this.getUserToken() && this.getUserInfo();
    }

    public register(user: UserRegisterDto) {
        return this.createUser(
            from(this.afAuth.createUserWithEmailAndPassword(user.email, user.password)).pipe(
                first(),
                tap(() => this.sendVerificationMail()),
                catchError((error) => throwError(error.message)),
            ),
            user.userName,
        );
    }

    public login(userDto: UserLoginDto) {
        return from(this.afAuth.signInWithEmailAndPassword(userDto.email, userDto.password)).pipe(
            first(),
            catchError((error) => throwError(error.message)),
            switchMap(() => this.userService.getCurrentUser()),
            tap((user) => this.setUserInfo(user)),
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

    public signInWithGoogle() {
        return this.createUser(this.signInWithProvider(new GoogleAuthProvider()));
    }

    public signInWithGitHub() {
        return this.createUser(this.signInWithProvider(new GithubAuthProvider()));
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
        );
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
        );
    }

    // TODO: Implemented only firebase part
    public forgotPassword(passwordResetEmail: string): Observable<void> {
        return from(this.afAuth.sendPasswordResetEmail(passwordResetEmail)).pipe(first());
    }

    private signInWithProvider(provider: firebase.auth.AuthProvider) {
        return from(this.afAuth.signInWithPopup(provider)).pipe(
            first(),
            catchError((error) => throwError(error.message)),
        );
    }

    private createUser(auth: Observable<firebase.auth.UserCredential>, userName: string | undefined = undefined) {
        return auth.pipe(
            switchMap((resp) =>
                this.userService.createUser({
                    uid: resp.user?.uid,
                    userName: userName ?? resp.user?.displayName!,
                    email: resp.user?.email ?? '',
                    image: resp.user?.photoURL ?? undefined,
                    timezone: new Date().getTimezoneOffset() / 60,
                })),
            tap((user) => this.setUserInfo(user)),
        );
    }

    private getUserInfo(): User | undefined {
        const userInfo = localStorage.getItem(this.userKeyName);

        if (userInfo) {
            return JSON.parse(userInfo);
        }

        return undefined;
    }

    private setUserInfo(user: User) {
        localStorage.setItem(this.userKeyName, JSON.stringify(user));
        this.userSubject.next(user);
        this.user = user;
    }

    private removeUserInfo() {
        localStorage.removeItem(this.userKeyName);
    }
}
