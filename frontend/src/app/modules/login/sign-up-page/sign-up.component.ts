import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { AuthService } from '@core/services/auth.service';
import { UserService } from '@core/services/user.service';
import { AuthHelper } from '@shared/utils/auth.helper';
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
        private userService: UserService,
        private authHelper: AuthHelper,
    ) { }

    public signUpGitHub() {
        this.authService.signInWithGitHub(false);
    }

    public signUpGoogle() {
        this.authService.signInWithGoogle(false);
    }

    public signUp() {
        this.authService
            .register({
                userName: this.registrationForm.value.username!,
                email: this.registrationForm.value.email!,
                password: this.registrationForm.value.password!,
            })
            .subscribe(
                () => {
                    this.authHelper.handleAuthSuccess(this.registrationForm.value.username!, false);
                },
                () => {
                    this.authHelper.handleAuthError(this.registrationForm);
                },
            );
    }
}
