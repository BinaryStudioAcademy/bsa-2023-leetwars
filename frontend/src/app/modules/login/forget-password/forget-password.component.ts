import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { AuthService } from '@core/services/auth.service';
import { ToastrNotificationsService } from '@core/services/toastr-notifications.service';

@Component({
    selector: 'app-forget-password',
    templateUrl: './forget-password.component.html',
    styleUrls: ['./forget-password.component.sass'],
})
export class ForgetPasswordComponent {
    public resetPasswordForm = new FormGroup({
        email: new FormControl('', [Validators.required]),
    });

    public isSubmitted = false;

    constructor(
        private auth: AuthService,
        private router: Router,
        private toastrService: ToastrNotificationsService,
    ) {}

    public resetPassword() {
        this.auth.forgotPassword(this.resetPasswordForm.value.email!).subscribe({
            error: () => {
                this.toastrService.showError('Something went wrong');
            },
            next: () => {
                this.isSubmitted = true;
            },
        });
    }

    public returnToSignIn() {
        this.router.navigate(['auth/login']);
    }
}
