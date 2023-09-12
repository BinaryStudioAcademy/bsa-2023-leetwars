import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { AuthService } from '@core/services/auth.service';
import { ToastrNotificationsService } from '@core/services/toastr-notifications.service';
import { UserService } from '@core/services/user.service';
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
        private router: Router,
        private userService: UserService,
        private toastrNotification: ToastrNotificationsService,
    ) {}

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
                () => {
                    this.router.navigate(['']);
                },
                () => {
                    this.isSignInError = true;
                    this.logInForm.markAsUntouched();
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
