import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { AuthService } from '@core/services/auth.service';
import { ToastrNotificationsService } from '@core/services/toastr-notifications.service';
import { UserService } from '@core/services/user.service';
import { User } from '@shared/models/user/user';
import { emailExistsValidator } from '@shared/utils/validation/check-email-exists.validator';
import { usernameExistsValidator } from '@shared/utils/validation/check-username-exists.validator';
import {
    emailMaxLength,
    passwordMaxLength,
    passwordMinLength,
    userNameMaxLength,
    userNameMinLength,
} from '@shared/utils/validation/form-control-validator-options';
import { latinCharactersPattern, passwordPattern } from '@shared/utils/validation/regex-patterns';
import { getErrorMessage } from '@shared/utils/validation/validation-helper';

@Component({
    selector: 'app-sign-up',
    templateUrl: './sign-up.component.html',
    styleUrls: ['./sign-up.component.sass'],
})
export class SignUpComponent {
    registrationForm = new FormGroup({
        email: new FormControl(
            '',
            [Validators.required, Validators.maxLength(emailMaxLength), Validators.email],
            [emailExistsValidator(this.userService)],
        ),
        username: new FormControl(
            '',
            [
                Validators.required,
                Validators.minLength(userNameMinLength),
                Validators.maxLength(userNameMaxLength),
                Validators.pattern(latinCharactersPattern),
            ],
            [usernameExistsValidator(this.userService)],
        ),
        password: new FormControl('', [
            Validators.required,
            Validators.minLength(passwordMinLength),
            Validators.maxLength(passwordMaxLength),
            Validators.pattern(passwordPattern),
        ]),
    });

    public getErrorMessage(formControlName: string) {
        return getErrorMessage(formControlName, this.registrationForm);
    }

    constructor(
        private authService: AuthService,
        private router: Router,
        private userService: UserService,
        private toastrNotification: ToastrNotificationsService,
    ) {}

    public signUpGitHub() {
        this.authService.signInWithGitHub().subscribe(
            (user: User) => {
                this.router.navigate(['/main']);
                this.toastrNotification.showSuccess(`${user.userName} was successfully signed up`);
                // add email sender to user.email
            },
            (error) => {
                this.toastrNotification.showError(error);
            },
        );
    }

    public signUpGoogle() {
        this.authService.signInWithGoogle().subscribe(
            (user: User) => {
                this.router.navigate(['/main']);
                this.toastrNotification.showSuccess(`${user.userName} was successfully signed up`);
                // add email sender to user.email
            },
            (error) => {
                this.toastrNotification.showError(error);
            },
        );
    }

    public signUp() {
        this.authService
            .register({
                userName: this.registrationForm.value.username!.trim(),
                email: this.registrationForm.value.email!.trim(),
                password: this.registrationForm.value.password!.trim(),
            })
            .subscribe(
                () => {
                    this.router.navigate(['/main']);
                    this.toastrNotification.showSuccess('You have successfully registered.');
                },
                (error) => {
                    this.toastrNotification.showError('Something went wrong');
                    console.error('Error :', error);
                },
            );
    }
}
