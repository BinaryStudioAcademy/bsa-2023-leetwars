import { Injectable } from '@angular/core';
import { CanActivate, CanActivateChild, CanMatch, Router, UrlTree } from '@angular/router';
import { AuthService } from '@core/services/auth.service';
import { Observable } from 'rxjs';

@Injectable({
    providedIn: 'root',
})
export class AuthorizedGuard implements CanActivate, CanActivateChild, CanMatch {
    constructor(private router: Router, private authService: AuthService) {}

    public canActivate() {
        return this.checkActivation();
    }

    public canActivateChild() {
        return this.checkActivation();
    }

    public canMatch(): boolean | UrlTree | Observable<boolean | UrlTree> | Promise<boolean | UrlTree> {
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
