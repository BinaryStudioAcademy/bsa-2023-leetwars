import {
    HttpEvent,
    HttpHandler,
    HttpInterceptor,
    HttpRequest } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { AuthService } from '@core/services/auth.service';
import { Observable } from 'rxjs';

@Injectable()
export class JwtInterceptor implements HttpInterceptor {
    constructor(private firebaseAuthService: AuthService) {}

    intercept(request: HttpRequest<unknown>, next: HttpHandler): Observable<HttpEvent<unknown>> {
        const userToken = this.firebaseAuthService.getUserToken();

        if (!userToken) {
            return next.handle(request);
        }

        const requestWithAuth = request.clone({
            headers: request.headers.set('Authorization', `Bearer ${userToken}`),
        });

        return next.handle(requestWithAuth);
    }
}
