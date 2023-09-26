import { ErrorHandler, Injectable } from '@angular/core';
import { throwError } from 'rxjs';

@Injectable({
    providedIn: 'root',
})
export class GlobalErrorHandlerService implements ErrorHandler {
    handleError(error: Error) {
        return throwError(error);
    }
}
