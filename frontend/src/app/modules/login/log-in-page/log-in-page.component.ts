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

    public isExistingEmail = true;

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
                        this.isExistingEmail = false;
                        this.logInForm.markAsUntouched();
                    }

                    return this.authService.login({
                        email: this.logInForm.value.email!.trim(),
                        password: this.logInForm.value.password!.trim(),
                    });
                }),
            )
            .subscribe(
                () => {
                    this.router.navigate(['/main']);
                },
                (error) => {
                    this.toastrNotification.showError('Something went wrong');
                    this.isSignInError = true;
                    this.logInForm.markAsUntouched();
                    console.error('Error :', error);
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
