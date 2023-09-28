import { Injectable } from '@angular/core';
import { CanActivate, CanActivateChild, Router } from '@angular/router';
import { AuthService } from '@core/services/auth.service';

@Injectable({
    providedIn: 'root',
})
export class UnAuthorizedGuard implements CanActivate, CanActivateChild {
    constructor(private router: Router, private authService: AuthService) {}

    canActivate() {
        return this.checkActivation();
    }

    canActivateChild() {
        return this.checkActivation();
    }

    private checkActivation() {
        if (this.authService.isAuthorized()) {
            this.router.navigate(['']);

            return false;
        }

        return true;
    }
}
