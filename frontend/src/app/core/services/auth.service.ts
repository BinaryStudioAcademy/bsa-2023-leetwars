import { Injectable } from '@angular/core';
import { AngularFireAuth } from '@angular/fire/compat/auth';
import { EditUserInfo } from '@shared/models/user/edit-user-info';
import { IUser } from '@shared/models/user/user';
import { IUserLogin } from '@shared/models/user/user-login';
import { IUserRegister } from '@shared/models/user/user-register';
import { AuthHelper } from '@shared/utils/auth.helper';
import { GithubAuthProvider, GoogleAuthProvider } from 'firebase/auth';
import firebase from 'firebase/compat';
import { BehaviorSubject, first, from, Observable, of, switchMap, tap, throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';

import { ToastrNotificationsService } from './toastr-notifications.service';
import { UserService } from './user.service';

@Injectable({
    providedIn: 'root',
})
export class AuthService {
    private providerName: string = 'firebase';

    private userSubject: BehaviorSubject<IUser | undefined>;

    public currentUser$: Observable<IUser | undefined>;

    private userKeyName = 'userInfo';

    private tokenKeyName = 'userToken';

    constructor(
        private afAuth: AngularFireAuth,
        private userService: UserService,
        private toastrNotification: ToastrNotificationsService,
        private authHelper: AuthHelper,
    ) {
        this.userSubject = new BehaviorSubject<IUser | undefined>(this.getUserInfo());
        this.currentUser$ = this.userSubject.asObservable();
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

    public register(user: IUserRegister) {
        return this.createUser(
            from(this.afAuth.createUserWithEmailAndPassword(user.email, user.password)).pipe(
                first(),
                tap(() => this.sendVerificationMail()),
                catchError((error) => throwError(error.message)),
            ),
            user.userName,
        );
    }

    public login(userDto: IUserLogin) {
        return from(this.afAuth.signInWithEmailAndPassword(userDto.email, userDto.password)).pipe(
            first(),
            catchError((error) => throwError(error.message)),
            switchMap(() => this.userService.getCurrentUser()),
            tap((user) => this.setUserInfo(user)),
        );
    }

    public logout() {
        this.removeUserInfo();
        this.userSubject.next(undefined);

        return from(this.afAuth.signOut());
    }

    public getUserToken(): string | null {
        return localStorage.getItem(this.tokenKeyName);
    }

    public signInWithGoogle(isLogin: boolean = true) {
        return this.signWithProvider(this.createUser(this.signInWithProvider(new GoogleAuthProvider())), isLogin);
    }

    public signInWithGitHub(isLogin: boolean = true) {
        return this.signWithProvider(this.createUser(this.signInWithProvider(new GithubAuthProvider())), isLogin);
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

    public updateUserEmail(email: string) {
        return this.afAuth.authState.subscribe(async (user) => {
            user?.updateEmail(email);
        });
    }

    public updateUserInfo(editUserInfo: EditUserInfo): Observable<IUser> {
        return this.userService.updateUser(editUserInfo).pipe(
            tap((user) => { this.updateUserEmail(user.email!); }),
        );
    }

    // TODO: Implemented only firebase part
    public forgotPassword(passwordResetEmail: string): Observable<void> {
        return from(this.afAuth.sendPasswordResetEmail(passwordResetEmail)).pipe(first());
    }

    public verifyPasswordResetCode(code: string): Observable<string | void> {
        return from(this.afAuth.verifyPasswordResetCode(code)).pipe(first());
    }

    public confirmPasswordReset(code: string, newPassword: string): Observable<void> {
        return from(this.afAuth.confirmPasswordReset(code, newPassword)).pipe(first());
    }

    public getUser() {
        return of(this.getUserInfo()!);
    }

    private signInWithProvider(provider: firebase.auth.AuthProvider) {
        return from(this.afAuth.signInWithPopup(provider)).pipe(
            first(),
            catchError((error) => throwError(error.message)),
        );
    }

    private signWithProvider(observable: Observable<IUser | undefined>, isLogin: boolean) {
        return this.catchAuthWithProviderError(observable).subscribe((user?: IUser) => {
            if (user) {
                this.authHelper.handleAuthSuccess(user.userName!, isLogin);
            }
        });
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

    public getUserInfo(): IUser | undefined {
        const userInfo = localStorage.getItem(this.userKeyName);

        if (userInfo) {
            return JSON.parse(userInfo);
        }

        return undefined;
    }

    private catchAuthWithProviderError(auth: Observable<IUser | undefined>): Observable<IUser | undefined> {
        return auth.pipe(
            catchError((error: string | Error) => {
                let message = error as string;

                if (typeof error !== 'string') {
                    message = error.message;
                }

                if (!message.toLowerCase().includes(this.providerName)) {
                    this.toastrNotification.showError(message);
                }

                return of(undefined);
            }),
        );
    }

    public setUserInfo(user: IUser) {
        localStorage.setItem(this.userKeyName, JSON.stringify(user));
        this.userSubject.next(user);
    }

    private removeUserInfo() {
        localStorage.removeItem(this.userKeyName);
    }
}
