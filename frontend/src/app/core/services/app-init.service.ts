import { Injectable } from '@angular/core';
import { from, Observable } from 'rxjs';

import { AuthService } from './auth.service';

@Injectable({
    providedIn: 'root',
})
export class AppInitService {
    constructor(private authService: AuthService) {}

    initializeApp(): Observable<void> {
        return from(this.authService.initializeAuth());
    }
}
