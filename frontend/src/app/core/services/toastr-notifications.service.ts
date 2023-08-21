import { Injectable } from '@angular/core';
import { ToastrService } from 'ngx-toastr';

@Injectable({
    providedIn: 'root',
})
export class ToastrNotificationsService {
    constructor(private toastr: ToastrService) {}

    showSuccess(message: string) {
        this.toastr.success(message, 'Success');
    }

    showInfo(message: string) {
        this.toastr.info(message, 'Info');
    }

    showWarring(message: string) {
        this.toastr.warning(message, 'Warring');
    }

    showError(message: string) {
        this.toastr.error(message, 'Error');
    }
}