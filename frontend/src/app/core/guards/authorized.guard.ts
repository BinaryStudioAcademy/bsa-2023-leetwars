import { Injectable } from '@angular/core';
import { CanActivate, CanActivateChild, CanMatch, Router } from '@angular/router';
import { AuthService } from '@core/services/auth.service';

@Injectable({
    providedIn: 'root',
})
export class AuthorizedGuard implements CanActivate, CanActivateChild, CanMatch {
    constructor(private router: Router, private authService: AuthService) {}

    canActivate() {
        return this.checkActivation();
    }

    canActivateChild() {
        return this.checkActivation();
    }

    canMatch() {
        return !!this.authService.isAuthorized();
    }

    private checkActivation() {
        if (this.authService.isAuthorized()) {
            return true;
        }

        this.router.navigate(['/auth/login']);

        return false;
    }
}
