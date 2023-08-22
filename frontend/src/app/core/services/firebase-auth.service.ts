import { Injectable, NgZone } from '@angular/core';
import { AngularFireAuth } from '@angular/fire/compat/auth';
import { GithubAuthProvider, GoogleAuthProvider } from 'firebase/auth';
import firebase from 'firebase/compat';
import { first, from, Observable, switchMap, tap, throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';

@Injectable({
    providedIn: 'root',
})
export class FirebaseAuthService {
    private tokenKeyName = 'user-token';

    constructor(private afAuth: AngularFireAuth, private ngZone: NgZone) {
        afAuth.authState.subscribe(async (user) => {
            if (user) {
                localStorage.setItem(this.tokenKeyName, await user.getIdToken());
            } else {
                localStorage.removeItem(this.tokenKeyName);
            }
        });
    }

    getUserToken(): string | null {
        return localStorage.getItem(this.tokenKeyName);
    }

    signUp(email: string, password: string): Observable<firebase.auth.UserCredential> {
        return from(this.afAuth.createUserWithEmailAndPassword(email, password)).pipe(
            first(),
            tap(() => this.sendVerificationMail()),
            catchError(error => throwError(error.message)),
        );
    }

    signIn(email: string, password: string): Observable<firebase.auth.UserCredential> {
        return from(this.afAuth.signInWithEmailAndPassword(email, password))
            .pipe(
                first(),
                catchError(error => throwError(error.message)),
            );
    }

    signInWithGoogle() {
        return this.signInWithProvider(new GoogleAuthProvider());
    }

    signInWithGitHub() {
        return this.signInWithProvider(new GithubAuthProvider());
    }

    changePassword(password: string): Observable<void> {
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

    sendVerificationMail(): Observable<void> {
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

    forgotPassword(passwordResetEmail: string): Observable<void> {
        return from(this.afAuth.sendPasswordResetEmail(passwordResetEmail)).pipe(first());
    }

    signOut(): Observable<void> {
        return from(this.afAuth.signOut()).pipe(first());
    }

    private signInWithProvider(provider: firebase.auth.AuthProvider) {
        return from(this.afAuth.signInWithPopup(provider))
            .pipe(
                first(),
                catchError(error => throwError(error.message)),
            );
    }
}
