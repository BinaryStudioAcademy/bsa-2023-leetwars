import { CustomToastrNotificationComponent } from '@shared/components/custom-toastr-notification/custom-toastr-notification.component';
import { GlobalConfig } from 'ngx-toastr';

export const toastrGlobalConfig: Partial<GlobalConfig> = {
    toastComponent: CustomToastrNotificationComponent,
    preventDuplicates: true,
};
