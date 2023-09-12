import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { AuthService } from '@core/services/auth.service';
import { UserService } from '@core/services/user.service';
import { IUser } from '@shared/models/user/user';
import { AuthHelper } from '@shared/utils/auth.helper';
import { getErrorMessage } from '@shared/utils/validation/validation-helper';
import { switchMap } from 'rxjs';

@Component({
    selector: 'app-log-in-page',
    templateUrl: './log-in-page.component.html',
    styleUrls: ['./log-in-page.component.sass'],
})
export class LogInPageComponent {
    public logInForm = new FormGroup({
        email: new FormControl('', [Validators.required]),
        password: new FormControl('', [Validators.required]),
    });

    public isSignInError = false;

    constructor(
        private authService: AuthService,
        private userService: UserService,
        private authHelper: AuthHelper,
    ) { }

    public getErrorMessage(formControlName: string) {
        return getErrorMessage(formControlName, this.logInForm);
    }

    public signIn() {
        this.userService
            .checkEmail(this.logInForm.value.email!)
            .pipe(
                switchMap((result) => {
                    if (!result) {
                        this.logInForm.markAsUntouched();
                    }

                    return this.authService.login({
                        email: this.logInForm.value.email!,
                        password: this.logInForm.value.password!,
                    });
                }),
            )
            .subscribe(
                ({ userName, firstName }: IUser) => {
                    this.authHelper.handleAuthSuccess(userName || (firstName!), true);
                },
                () => {
                    this.isSignInError = true;
                    this.authHelper.handleAuthError(this.logInForm);
                },
            );
    }

    public signInWithGitHub() {
        this.authService.signInWithGitHub();
    }

    public signInWithGoogle() {
        this.authService.signInWithGoogle();
    }
}
