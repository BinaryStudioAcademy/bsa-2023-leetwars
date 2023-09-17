import { HttpErrorResponse, HttpHandler, HttpInterceptor, HttpRequest } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';

@Injectable({
    providedIn: 'root',
})
export class ErrorInterceptor implements HttpInterceptor {
    public intercept(req: HttpRequest<unknown>, next: HttpHandler) {
        return next.handle(req).pipe(catchError((response: HttpErrorResponse) => throwError(response.error.error)));
    }
}
