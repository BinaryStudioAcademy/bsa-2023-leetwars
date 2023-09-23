import { Injectable } from '@angular/core';
import { ToastrService } from 'ngx-toastr';

@Injectable({
    providedIn: 'root',
})
export class ToastrNotificationsService {
    constructor(private toastr: ToastrService) {}

    public showSuccess(message: string) {
        this.toastr.success(message, 'Success');
    }

    public showInfo(message: string) {
        this.toastr.info(message, 'Info');
    }

    public showWarring(message: string) {
        this.toastr.warning(message, 'Warring');
    }

    public showError(message: string) {
        this.toastr.error(message, 'Error');
    }
}
