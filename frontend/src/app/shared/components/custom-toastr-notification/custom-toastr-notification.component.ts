import { animate, keyframes, state, style, transition, trigger } from '@angular/animations';
import { Component } from '@angular/core';
import { IndividualConfig, Toast } from 'ngx-toastr';

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
    override options: IndividualConfig = {
        timeOut: 10000,
        disableTimeOut: false,
        closeButton: false,
        extendedTimeOut: 0,
        progressBar: false,
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
        newestOnTop: false,
        payload: undefined,
    };
}
