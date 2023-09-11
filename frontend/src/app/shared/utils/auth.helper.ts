import { Injectable } from '@angular/core';
import { FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { ToastrNotificationsService } from '@core/services/toastr-notifications.service';


@Injectable({
    providedIn: 'root',
})
export class AuthHelper {
    constructor(
        private toastrNotification: ToastrNotificationsService,
        private router: Router,
    ) { }

    public handleAuthError(form: FormGroup) {
        this.toastrNotification.showError('Something went wrong');
        form.markAsUntouched();
    }

    public handleAuthSuccess(username: string, isLogin: boolean) {
        this.toastrNotification.showSuccess(`${username} was successfully signed ${isLogin ? 'in' : 'up'}`);
        this.router.navigate(['']);
    }
}
