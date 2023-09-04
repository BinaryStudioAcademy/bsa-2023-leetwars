import { Component, OnInit } from '@angular/core';
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
export class LogInPageComponent implements OnInit {
    logInForm = new FormGroup({
        email: new FormControl('', [Validators.required, Validators.email]),
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

    ngOnInit(): void {
        this.isDataIncorrect = false;
    }

    toggleShow() {
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

                    return this.authService.login(this.logInForm.value.email!, this.logInForm.value.password!);
                }),
            )
            .subscribe(
                () => {
                    this.router.navigateByUrl('/main');
                },
                (error) => {
                    this.toastrNotification.showError('Something went wrong');
                    console.error('Error :', error);
                },
            );
    }
}
