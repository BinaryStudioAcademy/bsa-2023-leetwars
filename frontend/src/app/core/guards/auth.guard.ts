import { Injectable } from '@angular/core';
import { CanActivate, CanActivateChild, Router } from '@angular/router';
import { AuthService } from '@core/services/auth.service';

@Injectable({
    providedIn: 'root',
})
export class AuthGuard implements CanActivate, CanActivateChild {
    constructor(private router: Router, private authService: AuthService) {}

    public canActivate() {
        return this.checkActivation();
    }

    public canActivateChild() {
        return this.checkActivation();
    }

    private checkActivation() {
        if (this.authService.isAuthorized()) {
            return true;
        }

        this.router.navigate(['/main']);

        return false;
    }
}
