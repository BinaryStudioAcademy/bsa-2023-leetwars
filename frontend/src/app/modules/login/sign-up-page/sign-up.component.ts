import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { AuthService } from '@core/services/auth.service';
import { UserService } from '@core/services/user.service';
import { AuthHelper } from '@shared/utils/auth.helper';
import {
    emailMaxLength,
    passwordMaxLength,
    passwordMinLength,
    userNameMaxLength,
    userNameMinLength,
} from '@shared/utils/validation/form-control-validator-options';
import { emailPattern, latinOrCyrillicCharactersPattern, passwordPattern } from '@shared/utils/validation/regex-patterns';
import { usernameExistsValidator } from '@shared/utils/validation/username-exists.validator';
import { getErrorMessage, getFirebaseErrorMessage } from '@shared/utils/validation/validation-helper';
import { FirebaseError } from 'firebase/app';

@Component({
    selector: 'app-sign-up',
    templateUrl: './sign-up.component.html',
    styleUrls: ['./sign-up.component.sass'],
})
export class SignUpComponent {
    validationError: string | null;

    registrationForm = new FormGroup({
        email: new FormControl('', [
            Validators.required,
            Validators.maxLength(emailMaxLength),
            Validators.pattern(emailPattern),
        ]),
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

    getErrorMessage(formControlName: string) {
        this.validationError = null;

        return getErrorMessage(formControlName, this.registrationForm);
    }

    constructor(private authService: AuthService, private userService: UserService, private authHelper: AuthHelper) {}

    signUpGitHub() {
        this.authService.signInWithGitHub(false);
    }

    signUpGoogle() {
        this.authService.signInWithGoogle(false);
    }

    signUp() {
        this.authService
            .register({
                userName: this.registrationForm.value.username!,
                email: this.registrationForm.value.email!,
                password: this.registrationForm.value.password!,
            })
            .subscribe(
                () => {
                    this.validationError = null;
                    this.authHelper.handleAuthSuccess(this.registrationForm.value.username!, false);
                },
                (error: Error | string) => {
                    this.validationError =
                        error instanceof FirebaseError ? getFirebaseErrorMessage(error.code) : (error as string);
                },
            );
    }
}
