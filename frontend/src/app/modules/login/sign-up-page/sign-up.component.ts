import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { AuthService } from '@core/services/auth.service';
import { ToastrNotificationsService } from '@core/services/toastr-notifications.service';
import { UserService } from '@core/services/user.service';
import { emailExistsValidator } from '@shared/utils/validation/email-exists.validator';
import {
    emailMaxLength,
    passwordMaxLength,
    passwordMinLength,
    userNameMaxLength,
    userNameMinLength,
} from '@shared/utils/validation/form-control-validator-options';
import {
    emailPattern,
    latinOrCyrillicCharactersPattern,
    passwordPattern,
} from '@shared/utils/validation/regex-patterns';
import { usernameExistsValidator } from '@shared/utils/validation/username-exists.validator';
import { getErrorMessage } from '@shared/utils/validation/validation-helper';

@Component({
    selector: 'app-sign-up',
    templateUrl: './sign-up.component.html',
    styleUrls: ['./sign-up.component.sass'],
})
export class SignUpComponent {
    public registrationForm = new FormGroup({
        email: new FormControl(
            '',
            [Validators.required, Validators.maxLength(emailMaxLength), Validators.pattern(emailPattern)],
            [emailExistsValidator(this.userService)],
        ),
        username: new FormControl(
            '',
            [
                Validators.required,
                Validators.minLength(userNameMinLength),
                Validators.maxLength(userNameMaxLength),
                Validators.pattern(latinOrCyrillicCharactersPattern),
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
        this.authService.signInWithGitHub(false);
    }

    public signUpGoogle() {
        this.authService.signInWithGoogle(false);
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
                    this.router.navigate(['']);
                    this.toastrNotification.showSuccess('You have successfully registered.');
                },
                (error) => {
                    this.toastrNotification.showError('Something went wrong');
                    console.error('Error :', error);
                },
            );
    }
}
