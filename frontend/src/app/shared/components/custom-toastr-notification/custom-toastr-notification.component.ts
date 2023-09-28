import { animate, keyframes, state, style, transition, trigger } from '@angular/animations';
import { Component } from '@angular/core';
import { CodeFightService } from '@core/services/code-fight.service';
import { NotificationService } from '@core/services/notification.service';
import { ToastrNotificationsService } from '@core/services/toastr-notifications.service';
import { IndividualConfig, Toast, ToastPackage } from 'ngx-toastr';

@Component({
    selector: 'app-custom-toastr-notification',
    templateUrl: './custom-toastr-notification.component.html',
    styleUrls: ['./custom-toastr-notification.component.sass'],
    animations: [
        trigger('flyInOut', [
            state(
                'inactive',
                style({
                    opacity: 0,
                }),
            ),
            transition(
                'inactive => active',
                animate(
                    '400ms ease-out',
                    keyframes([
                        style({
                            transform: 'translate3d(100%, 0, 0) skewX(-30deg)',
                            opacity: 0,
                        }),
                        style({
                            transform: 'skewX(20deg)',
                            opacity: 1,
                        }),
                        style({
                            transform: 'skewX(-5deg)',
                            opacity: 1,
                        }),
                        style({
                            transform: 'none',
                            opacity: 1,
                        }),
                    ]),
                ),
            ),
            transition(
                'active => removed',
                animate(
                    '400ms ease-out',
                    keyframes([
                        style({
                            opacity: 1,
                        }),
                        style({
                            transform: 'translate3d(100%, 0, 0) skewX(30deg)',
                            opacity: 0,
                        }),
                    ]),
                ),
            ),
        ]),
    ],
    preserveWhitespaces: false,
})
export class CustomToastrNotificationComponent extends Toast {
    codeFightTitle = 'CodeFight';

    override options: IndividualConfig = {
        timeOut: 10000,
        disableTimeOut: false,
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

    constructor(
        public override toastPackage: ToastPackage,
        protected override toastrService: ToastrNotificationsService,
        private notificationService: NotificationService,
        private codeFightService: CodeFightService,
    ) {
        super(toastrService, toastPackage);
    }

    onCodeFightStart() {
        this.notificationService.removeNotification(this.toastrService.codeFightNotification);
        this.notificationService.hideNofitications();

        this.codeFightService.sendCodeFightStart(this.toastrService.codeFightNotification).subscribe();
    }

    onCodeFightRefuse() {
        this.codeFightService.sendCodeFightRequestEnded(this.toastrService.codeFightNotification).subscribe();

        this.notificationService.removeNotification(this.toastrService.codeFightNotification);
    }
}
