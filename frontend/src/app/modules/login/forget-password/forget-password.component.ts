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
    resetPasswordForm = new FormGroup({
        email: new FormControl('', [Validators.required]),
    });

    isSubmitted = false;

    constructor(private auth: AuthService, private router: Router, private toastrService: ToastrNotificationsService) {}

    resetPassword() {
        this.auth.forgotPassword(this.resetPasswordForm.value.email!).subscribe({
            error: () => {
                this.toastrService.showError('Something went wrong');
            },
            next: () => {
                this.isSubmitted = true;
            },
        });
    }

    returnToSignIn() {
        this.router.navigate(['auth/login']);
    }
}
