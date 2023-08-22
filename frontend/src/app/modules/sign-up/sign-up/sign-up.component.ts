import { Component, OnInit } from '@angular/core';
import { faEyeSlash, faEye } from '@fortawesome/free-regular-svg-icons';

@Component({
    selector: 'app-sign-up',
    templateUrl: './sign-up.component.html',
    styleUrls: ['./sign-up.component.sass'],
})
export class SignUpComponent implements OnInit {
    faEyeSlash = faEyeSlash;
    faEye = faEye;

    public showPassword = false;

    constructor() {}

    ngOnInit(): void {}

    public togglePasswordVisibility() {
        this.showPassword = !this.showPassword;
    }
}
