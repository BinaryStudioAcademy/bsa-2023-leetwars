import { HttpErrorResponse, HttpHandler, HttpInterceptor, HttpRequest } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { AuthService } from '@core/services/auth.service';
import { throwError } from 'rxjs';
import { catchError, switchMap } from 'rxjs/operators';

@Injectable({
    providedIn: 'root',
})
export class ErrorInterceptor implements HttpInterceptor {
    constructor(private authService: AuthService) {}

    intercept(req: HttpRequest<unknown>, next: HttpHandler) {
        return next.handle(req).pipe(
            catchError((errorResponse: HttpErrorResponse) => {
                if (errorResponse.status === 401) {
                    return this.handle401Error(req, next);
                }

                return throwError(errorResponse.error);
            }),
        );
    }

    private handle401Error(req: HttpRequest<unknown>, next: HttpHandler) {
        return this.authService.refreshFirebaseToken().pipe(
            switchMap((newToken) => {
                const clonedRequest = req.clone({
                    setHeaders: {
                        Authorization: `Bearer ${newToken}`,
                    },
                });

                return next.handle(clonedRequest).pipe(catchError((refreshError) => throwError(refreshError)));
            }),
        );
    }
}
