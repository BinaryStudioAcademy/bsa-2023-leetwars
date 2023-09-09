import { Injectable } from '@angular/core';
import { CanActivate } from '@angular/router';
import { HeaderService } from '@core/services/header-service';

@Injectable({
    providedIn: 'root',
})
export class HideHeaderGuard implements CanActivate {
    constructor(private headerService: HeaderService) {}

    canActivate(): boolean {
        this.headerService.setShowHeader(false);

        return true;
    }
}
