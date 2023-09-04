import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { AuthService } from '@core/services/auth.service';
import { ToastrNotificationsService } from '@core/services/toastr-notifications.service';
import { UserService } from '@core/services/user.service';
import { User } from '@shared/models/user/user';
import { emailMaxLength } from '@shared/utils/validation/form-control-validator-options';
import { getErrorMessage } from '@shared/utils/validation/validation-helper';
import { switchMap } from 'rxjs';

@Component({
    selector: 'app-log-in-page',
    templateUrl: './log-in-page.component.html',
    styleUrls: ['./log-in-page.component.sass'],
})
export class LogInPageComponent implements OnInit {
    logInForm = new FormGroup({
        email: new FormControl('', [Validators.required, Validators.maxLength(emailMaxLength), Validators.email]),
        password: new FormControl('', [Validators.required]),
    });

    isExistingEmail = true;

    showPassword: boolean = false;

    isDataIncorrect: boolean;

    constructor(
        private authService: AuthService,
        private router: Router,
        private userService: UserService,
        private toastrNotification: ToastrNotificationsService,
    ) {}

    public ngOnInit(): void {
        this.isDataIncorrect = false;
    }

    public toggleShow() {
        this.showPassword = !this.showPassword;
    }

    getErrorMessage(formControlName: string) {
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
                        email: this.logInForm.value.email!,
                        password: this.logInForm.value.password!,
                    });
                }),
            )
            .subscribe(
                () => {
                    this.router.navigate(['/main']);
                },
                (error) => {
                    this.toastrNotification.showError('Something went wrong');
                    console.error('Error :', error);
                },
            );
    }

    public signInWithGitHub() {
        this.authService.signInWithGitHub().subscribe(
            (user: User) => {
                this.router.navigate(['/main']);
                this.toastrNotification.showSuccess(`${user.userName} was successfully signed in`);
                // add email sender to user.email
            },
            (error) => {
                this.toastrNotification.showError(error);
            },
        );
    }

    public signInWithGoogle() {
        this.authService.signInWithGoogle().subscribe(
            (user: User) => {
                this.router.navigate(['/main']);
                this.toastrNotification.showSuccess(`${user.userName} was successfully signed in`);
                // add email sender to user.email
            },
            (error) => {
                this.toastrNotification.showError(error);
            },
        );
    }
}
