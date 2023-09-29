import { Injectable } from '@angular/core';
import { INotificationModel } from '@shared/models/notifications/notifications';
import { toastrCodeFightOptions } from '@shared/utils/toastr/toastr-code-fight-options';
import { ToastrService } from 'ngx-toastr';

@Injectable({
    providedIn: 'root',
})
export class ToastrNotificationsService extends ToastrService {
    codeFightNotification: INotificationModel;

    codeFightType?: 'success' | 'error';

    private codeFightTitle = 'CodeFight';

    private codeFightDefaultTimeOut = 10000;

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

    showCodeFightNotification(notification: INotificationModel, codeFightType?: 'success' | 'error') {
        this.codeFightNotification = notification;
        this.codeFightType = codeFightType;

        super.show(notification.message, this.codeFightTitle, {
            ...toastrCodeFightOptions,
            toastClass: `custom-toast${codeFightType || ''}`,
            timeOut: notification.showFor ?? this.codeFightDefaultTimeOut,
        }, codeFightType);
    }
}
