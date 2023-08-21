import { Injectable } from '@angular/core';
import { CanActivate, Router } from '@angular/router';
import { AuthService } from '@core/services/auth.service';

@Injectable({
    providedIn: 'root',
})
export class AuthGuard implements CanActivate {
    constructor(private router: Router, private authService: AuthService) {
        // do nothing
    }

    public canActivate() {
        if (this.authService.isAuthorized()) {
            return true;
        }

        this.router.navigate(['/main']);

        return false;
    }
}
