import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { AuthService } from '@core/services/auth.service';
import { ToastrNotificationsService } from '@core/services/toastr-notifications.service';
import { User } from '@shared/models/user/user';

@Component({
    selector: 'app-log-in-page',
    templateUrl: './log-in-page.component.html',
    styleUrls: ['./log-in-page.component.sass'],
})
export class LogInPageComponent implements OnInit {
    //TODO: Add real validation and don't forget to add it in html file
    logInForm = new FormGroup({
        email: new FormControl('', [Validators.required, Validators.email]),
        password: new FormControl('', Validators.required),
    });

    showPassword: boolean = false;

    isDataIncorrect: boolean;

    constructor(private authService: AuthService, private router: Router, private toastr: ToastrNotificationsService) {}

    public ngOnInit(): void {
        this.isDataIncorrect = false;
    }

    public toggleShow() {
        this.showPassword = !this.showPassword;
    }

    public signIn() {
        this.authService
            .login({ email: this.logInForm.value.email!, password: this.logInForm.value.password! })
            .subscribe(() => {
                this.router.navigate(['/main']);
            });
    }

    public signInWithGitHub() {
        this.authService.signInWithGitHub().subscribe(
            (user: User) => {
                this.router.navigate(['/main']);
                this.toastr.showSuccess(`${user.userName} was successfully signed up`);
                // add email sender to user.email
            },
            (error) => {
                this.toastr.showError(error);
            },
        );
    }

    public signInWithGoogle() {
        this.authService.signInWithGoogle().subscribe(
            (user: User) => {
                this.router.navigate(['/main']);
                this.toastr.showSuccess(`${user.userName} was successfully signed up`);
                // add email sender to user.email
            },
            (error) => {
                this.toastr.showError(error);
            },
        );
    }
}
