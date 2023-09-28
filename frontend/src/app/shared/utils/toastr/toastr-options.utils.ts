import { IndividualConfig } from 'ngx-toastr';

export const ToastrGlobalOptions: IndividualConfig = {
    timeOut: 10000,
    disableTimeOut: 'extendedTimeOut',
    closeButton: false,
    extendedTimeOut: 0,
    progressBar: true,
    progressAnimation: 'increasing',
    enableHtml: false,
    toastClass: '',
    positionClass: '',
    titleClass: '',
    messageClass: '',
    easing: '',
    easeTime: '',
    tapToDismiss: true,
    onActivateTick: false,
    newestOnTop: true,
    payload: undefined,
};
