import { Injectable } from '@angular/core';
import { ToastrService } from 'ngx-toastr';

@Injectable({
    providedIn: 'root',
})
export class ToastrNotificationsService extends ToastrService {
    isCodeFightNotification: boolean;

    showSuccess(message: string) {
        super.success(message, 'Success');
    }

    showInfo(message: string) {
        super.info(message, 'Info');
    }

    showWarning(message: string) {
        super.warning(message, 'Warning');
    }

    showError(message: string) {
        super.error(message, 'Error');
    }

    showCodeFightNotification() {
        this.isCodeFightNotification = true;
        super.show();
    }
}
