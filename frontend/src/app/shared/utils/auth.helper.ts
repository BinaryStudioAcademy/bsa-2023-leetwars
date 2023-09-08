import { Injectable } from '@angular/core';
import { FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { EmailService } from '@core/services/email.service';
import { ToastrNotificationsService } from '@core/services/toastr-notifications.service';

import { getWelcomeEmail } from './welcome-email';

@Injectable({
    providedIn: 'root',
})
export class AuthHelper {
    constructor(
        private toastrNotification: ToastrNotificationsService,
        private emailService: EmailService,
        private router: Router,
    ) { }

    public handleAuthError(form: FormGroup) {
        this.toastrNotification.showError('Something went wrong');
        form.markAsUntouched();
    }

    public handleAuthSuccess(username: string, userEmail: string, isLogin: boolean) {
        this.toastrNotification.showSuccess(`${username} was successfully signed ${isLogin ? 'in' : 'up'}`);
        this.router.navigate(['']);
        if (!isLogin) {
            this.emailService.sendEmail(getWelcomeEmail(username, userEmail));
        }
    }
}
