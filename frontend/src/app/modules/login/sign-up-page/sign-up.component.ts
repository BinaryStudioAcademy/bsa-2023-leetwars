import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { AuthService } from '@core/services/auth.service';
import { ToastrNotificationsService } from '@core/services/toastr-notifications.service';
import { UserService } from '@core/services/user.service';
import {
    passwordMaxLength,
    passwordMinLength,
    userNameMaxLength,
    userNameMinLength,
} from '@shared/utils/validation/form-control-validator-options';
import { latinCharactersPattern, passwordPattern } from '@shared/utils/validation/regex-patterns';
import { getErrorMessage } from '@shared/utils/validation/validation-helper';
import { switchMap } from 'rxjs';

@Component({
    selector: 'app-sign-up',
    templateUrl: './sign-up.component.html',
    styleUrls: ['./sign-up.component.sass'],
})
export class SignUpComponent {
    isExistingEmail = false;

    registrationForm = new FormGroup({
        email: new FormControl('', [Validators.required, Validators.email]),
        username: new FormControl('', [
            Validators.required,
            Validators.minLength(userNameMinLength),
            Validators.maxLength(userNameMaxLength),
            Validators.pattern(latinCharactersPattern),
        ]),
        password: new FormControl('', [
            Validators.required,
            Validators.minLength(passwordMinLength),
            Validators.maxLength(passwordMaxLength),
            Validators.pattern(passwordPattern),
        ]),
    });

    getErrorMessage(formControlName: string) {
        return getErrorMessage(formControlName, this.registrationForm);
    }

    constructor(
        private authService: AuthService,
        private router: Router,
        private userService: UserService,
        private toastrNotification: ToastrNotificationsService,
    ) {}

    signUp() {
        this.userService
            .checkEmail(this.registrationForm.value.email!)
            .pipe(
                switchMap((result) => {
                    if (result) {
                        this.isExistingEmail = true;
                        this.registrationForm.markAsUntouched();
                    }

                    return this.authService.register(
                        this.registrationForm.value.username!,
                        this.registrationForm.value.email!,
                        this.registrationForm.value.password!,
                    );
                }),
            )
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
