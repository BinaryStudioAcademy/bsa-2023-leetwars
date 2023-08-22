import { Component, OnInit } from '@angular/core';
import { faEye, faEyeSlash } from '@fortawesome/free-regular-svg-icons';

@Component({
    selector: 'app-sign-up',
    templateUrl: './sign-up.component.html',
    styleUrls: ['./sign-up.component.sass'],
})
export class SignUpComponent implements OnInit {
    faEyeSlash = faEyeSlash;

    faEye = faEye;

    public showPassword: boolean;

    ngOnInit(): void {
        this.showPassword = false;
    }

    public togglePasswordVisibility() {
        this.showPassword = !this.showPassword;
    }
}
