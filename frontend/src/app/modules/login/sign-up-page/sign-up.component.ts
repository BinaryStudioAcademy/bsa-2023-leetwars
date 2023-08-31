import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { AuthService } from '@core/services/auth.service';
import { ToastrNotificationsService } from '@core/services/toastr-notifications.service';
import { User } from '@shared/models/user/user';

@Component({
    selector: 'app-sign-up',
    templateUrl: './sign-up.component.html',
    styleUrls: ['./sign-up.component.sass'],
})
export class SignUpComponent {
    //TODO: Add real validation and don't forget to add it in html file
    registrationForm = new FormGroup({
        email: new FormControl('', [Validators.required, Validators.email]),
        username: new FormControl('', [Validators.required]),
        password: new FormControl('', [Validators.required]),
    });

    constructor(private authService: AuthService, private router: Router, private toastr: ToastrNotificationsService) {}

    public signUpGitHub() {
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

    public signUpGoogle() {
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

    public signUp() {
        this.authService
            .register({
                userName: this.registrationForm.value.username!,
                email: this.registrationForm.value.email!,
                password: this.registrationForm.value.password!,
            })
            .subscribe(() => {
                this.router.navigate(['/main']);
            });
    }
}
