import { Injectable } from '@angular/core';
import { CanActivate } from '@angular/router';
import { HeaderService } from '@core/services/header-service';

@Injectable({
    providedIn: 'root',
})
export class HeaderGuard implements CanActivate {
    constructor(private headerService: HeaderService) {}

    public canActivate() {
        this.headerService.setShowHeader(true);

        return true;
    }
}
