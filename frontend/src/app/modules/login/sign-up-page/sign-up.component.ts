import { Component } from '@angular/core';

@Component({
    selector: 'app-sign-up',
    templateUrl: './sign-up.component.html',
    styleUrls: ['./sign-up.component.sass'],
})
export class SignUpComponent {
    public showPassword = false;

    public togglePasswordVisibility() {
        this.showPassword = !this.showPassword;
    }
}
