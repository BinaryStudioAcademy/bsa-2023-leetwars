import { Injectable } from '@angular/core';
import { AngularFireAuth } from '@angular/fire/compat/auth';
import { IEditUserInfo } from '@shared/models/user/edit-user-info';
import { IUser } from '@shared/models/user/user';
import { IUserLogin } from '@shared/models/user/user-login';
import { IUserRegister } from '@shared/models/user/user-register';
import { AuthHelper } from '@shared/utils/auth.helper';
import { getFirebaseErrorMessage } from '@shared/utils/validation/validation-helper';
import { GithubAuthProvider, GoogleAuthProvider } from 'firebase/auth';
import firebase from 'firebase/compat';
import { BehaviorSubject, first, firstValueFrom, from, Observable, of, switchMap, tap, throwError } from 'rxjs';
import { catchError, map } from 'rxjs/operators';

import { ToastrNotificationsService } from './toastr-notifications.service';
import { UserService } from './user.service';

@Injectable({
    providedIn: 'root',
})
export class AuthService {
    userSubject: BehaviorSubject<IUser | undefined>;

    currentUser$: Observable<IUser | undefined>;

    private userKeyName = 'userInfo';

    private tokenKeyName = 'userToken';

    private providerName = 'firebase';

    private popUpErrorMessage = 'auth/cancelled-popup-request';

    private notAuthorizedErrorMessage = 'User is not authorized';

    constructor(
        private afAuth: AngularFireAuth,
        private userService: UserService,
        private toastrNotification: ToastrNotificationsService,
        private authHelper: AuthHelper,
    ) {
        this.userSubject = new BehaviorSubject<IUser | undefined>(this.getUserInfo());
        this.currentUser$ = this.userSubject.asObservable();
        this.initializeAuth();
    }

    async initializeAuth(): Promise<void> {
        const user = await firstValueFrom(this.afAuth.authState);

        if (user) {
            localStorage.setItem(this.tokenKeyName, await user.getIdToken());
        } else {
            localStorage.removeItem(this.tokenKeyName);
        }
    }

    isAuthorized() {
        return this.getUserToken() && this.getUserInfo();
    }

    register(user: IUserRegister) {
        return this.createUser(
            from(this.afAuth.createUserWithEmailAndPassword(user.email, user.password)).pipe(
                first(),
                tap(() => this.sendVerificationMail()),
            ),
            undefined,
            user.userName,
        );
    }

    login(userDto: IUserLogin) {
        return from(this.afAuth.signInWithEmailAndPassword(userDto.email, userDto.password)).pipe(
            switchMap(() => this.afAuth.idToken),
            first(),
            tap((token) => {
                this.setIdToken(token!);
            }),
            switchMap(() => this.userService.getCurrentUser()),
            tap((user) => this.setUserInfo(user)),
        );
    }

    logout() {
        this.removeUserInfo();
        this.userSubject.next(undefined);

        return from(this.afAuth.signOut());
    }

    getUserToken(): string | null {
        return localStorage.getItem(this.tokenKeyName);
    }

    signInWithGoogle(isLogin: boolean = true) {
        return this.signWithProvider(this.createUser(this.signInWithProvider(new GoogleAuthProvider()), true), isLogin);
    }

    signInWithGitHub(isLogin: boolean = true) {
        return this.signWithProvider(this.createUser(this.signInWithProvider(new GithubAuthProvider()), true), isLogin);
    }

    changePassword(password: string): Observable<void> {
        return from(this.afAuth.currentUser).pipe(
            first(),
            switchMap((user) => {
                if (user) {
                    return user.updatePassword(password);
                }

                throw new Error(this.notAuthorizedErrorMessage);
            }),
        );
    }

    sendVerificationMail() {
        return from(this.afAuth.currentUser).pipe(
            first(),
            switchMap((user) => {
                if (user) {
                    return user.sendEmailVerification();
                }

                throw new Error(this.notAuthorizedErrorMessage);
            }),
        );
    }

    updateUserEmail(email: string) {
        return this.afAuth.authState.subscribe(async (user) => {
            user?.updateEmail(email);
        });
    }

    updateUserInfo(editUserInfo: IEditUserInfo): Observable<IUser> {
        return this.userService.updateUser(editUserInfo).pipe(
            tap((user) => {
                this.updateUserEmail(user.email!);
            }),
        );
    }

    forgotPassword(passwordResetEmail: string): Observable<void> {
        return from(this.afAuth.sendPasswordResetEmail(passwordResetEmail)).pipe(first());
    }

    verifyPasswordResetCode(code: string): Observable<string | void> {
        return from(this.afAuth.verifyPasswordResetCode(code)).pipe(first());
    }

    confirmPasswordReset(code: string, newPassword: string): Observable<void> {
        return from(this.afAuth.confirmPasswordReset(code, newPassword)).pipe(first());
    }

    getUserInfo(): IUser | undefined {
        const userInfo = localStorage.getItem(this.userKeyName);

        if (userInfo) {
            return JSON.parse(userInfo);
        }

        return undefined;
    }

    getUser(): Observable<IUser> {
        return of(this.getUserInfo()!);
    }

    linkGitHub(): Observable<firebase.auth.UserCredential | null> {
        return this.afAuth.authState.pipe(
            first(),
            switchMap((user) => {
                if (!user) {
                    return of(null);
                }

                return user.linkWithPopup(new GithubAuthProvider()).then(
                    (result) => result,
                    (error) => {
                        this.toastrNotification.showError(error.message);

                        return null;
                    },
                );
            }),
            catchError((error) => {
                this.toastrNotification.showError(error.message);

                return of(null);
            }),
        );
    }

    getFirebaseUserInfo() {
        return this.afAuth.authState.pipe(map((user) => (user ? user.providerData : [])));
    }

    setUserInfo(user: IUser) {
        localStorage.setItem(this.userKeyName, JSON.stringify(user));
        this.userSubject.next(user);
    }

    private signInWithProvider(provider: firebase.auth.AuthProvider): Observable<firebase.auth.UserCredential> {
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

    private createUser(
        auth: Observable<firebase.auth.UserCredential>,
        provider: boolean | undefined = false,
        userName: string | undefined = undefined,
    ) {
        return auth.pipe(
            switchMap((resp) =>
                this.userService.createUser({
                    uid: resp.user?.uid,
                    userName: userName ?? resp.user?.displayName!,
                    email: resp.user?.email ?? '',
                    image: resp.user?.photoURL ?? undefined,
                    timezone: new Date().getTimezoneOffset() / 60,
                    isWithProvider: provider ?? false,
                })),
            tap((user) => this.setUserInfo(user)),
        );
    }

    private catchAuthWithProviderError(auth: Observable<IUser | undefined>): Observable<IUser | undefined> {
        return auth.pipe(
            catchError((error: string | Error) => {
                let message = error as string;

                if (typeof error !== 'string') {
                    message = error.message;
                }

                if (
                    message.toLowerCase().includes(this.providerName) &&
                    !message.toLowerCase().includes(this.popUpErrorMessage)
                ) {
                    this.toastrNotification.showError(getFirebaseErrorMessage(message) ?? 'Something went wrong');
                }

                return of(undefined);
            }),
        );
    }

    private setIdToken(token: string) {
        localStorage.setItem(this.tokenKeyName, token);
    }

    private removeUserInfo() {
        localStorage.removeItem(this.userKeyName);
    }
}
