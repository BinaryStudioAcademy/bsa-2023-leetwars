import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { AuthService } from '@core/services/auth.service';
import { ToastrNotificationsService } from '@core/services/toastr-notifications.service';
import { UserService } from '@core/services/user.service';
import { User } from '@shared/models/user/user';
import { latinCharactersPattern, passwordPattern } from '@shared/regaxes/user-regax-patterns';
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
            Validators.minLength(2),
            Validators.maxLength(50),
            Validators.pattern(latinCharactersPattern),
        ]),
        password: new FormControl('', [
            Validators.required,
            Validators.minLength(8),
            Validators.maxLength(32),
            Validators.pattern(passwordPattern),
        ]),
    });

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
        this.userService
            .checkEmail(this.registrationForm.value.email!)
            .pipe(
                switchMap((result) => {
                    if (result) {
                        this.isExistingEmail = true;
                        this.registrationForm.markAsUntouched();
                    }

                    return this.authService.register({
                        userName: this.registrationForm.value.username!,
                        email: this.registrationForm.value.email!,
                        password: this.registrationForm.value.password!,
                    });
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
