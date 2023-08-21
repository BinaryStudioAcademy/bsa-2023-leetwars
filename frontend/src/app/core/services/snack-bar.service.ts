import { Injectable } from '@angular/core';
import { MatSnackBar, MatSnackBarConfig } from '@angular/material/snack-bar';

@Injectable({
    providedIn: 'root',
})
export class SnackBarService {
    // eslint-disable-next-line no-empty-function
    constructor(private snackBar: MatSnackBar) {}

    private openSnackBar(message: string, config: MatSnackBarConfig) {
        this.snackBar.open(message, 'OK', config);
    }

    showSuccessMessage(message: string) {
        const config: MatSnackBarConfig = {
            duration: 3000,
            panelClass: 'success-snack-bar',
        };

        this.openSnackBar(message, config);
    }

    showInfoMessage(message: string) {
        const config: MatSnackBarConfig = {
            duration: 3000,
            panelClass: 'info-snack-bar',
        };

        this.openSnackBar(message, config);
    }

    showWarringMessage(message: string) {
        const config: MatSnackBarConfig = {
            duration: 3000,
            panelClass: 'warring-snack-bar',
        };

        this.openSnackBar(message, config);
    }

    showErrorMessage(message: string) {
        const config: MatSnackBarConfig = {
            duration: 3000,
            panelClass: 'error-snack-bar',
        };

        this.openSnackBar(message, config);
    }
}
