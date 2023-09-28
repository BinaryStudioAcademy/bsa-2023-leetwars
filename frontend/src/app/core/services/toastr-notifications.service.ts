import { Injectable } from '@angular/core';
import { INotificationModel } from '@shared/models/notifications/notifications';
import { ToastrService } from 'ngx-toastr';

@Injectable({
    providedIn: 'root',
})
export class ToastrNotificationsService extends ToastrService {
    codeFightNotification: INotificationModel;

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

    showCodeFightNotification(notification: INotificationModel) {
        this.codeFightNotification = notification;

        super.show(notification.message, 'CodeFight', {
            toastClass: 'custom-toast',
            positionClass: 'toast-bottom-right',
            progressBar: true,
            timeOut: notification.showFor,
        });
    }
}
