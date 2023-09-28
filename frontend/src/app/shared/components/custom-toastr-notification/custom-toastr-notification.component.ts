import { Component } from '@angular/core';
import { CodeFightService } from '@core/services/code-fight.service';
import { NotificationService } from '@core/services/notification.service';
import { ToastrNotificationsService } from '@core/services/toastr-notifications.service';
import { toastrAnimations } from '@shared/utils/toastr/toastr-animations';
import { ToastrGlobalOptions } from '@shared/utils/toastr/toastr-options.utils';
import { Toast, ToastPackage } from 'ngx-toastr';

@Component({
    selector: 'app-custom-toastr-notification',
    templateUrl: './custom-toastr-notification.component.html',
    styleUrls: ['./custom-toastr-notification.component.sass'],
    animations: [toastrAnimations()],
    preserveWhitespaces: false,
})
export class CustomToastrNotificationComponent extends Toast {
    codeFightTitle = 'CodeFight';

    override options = ToastrGlobalOptions;

    constructor(
        public override toastPackage: ToastPackage,
        protected override toastrService: ToastrNotificationsService,
        private notificationService: NotificationService,
        private codeFightService: CodeFightService,
    ) {
        super(toastrService, toastPackage);
    }

    onCodeFightStart() {
        this.codeFightService.sendCodeFightStart(this.toastrService.codeFightNotification).subscribe(() => {
            this.notificationService.removeNotification(this.toastrService.codeFightNotification);
        });
    }

    onCodeFightRefuse() {
        this.codeFightService.sendCodeFightRequestEnded(this.toastrService.codeFightNotification).subscribe(() => {
            this.notificationService.removeNotification(this.toastrService.codeFightNotification);
        });
    }
}
