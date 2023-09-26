import { Injectable } from '@angular/core';
import { FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { ToastrNotificationsService } from '@core/services/toastr-notifications.service';

@Injectable({
    providedIn: 'root',
})
export class AuthHelper {
    constructor(private toastrNotification: ToastrNotificationsService, private router: Router) {}

    handleAuthError(form: FormGroup) {
        form.markAsUntouched();
    }

    handleAuthSuccess(username: string, isLogin: boolean) {
        this.toastrNotification.showSuccess(`${username} was successfully signed ${isLogin ? 'in' : 'up'}`);
        this.router.navigate(['']);
    }
}
