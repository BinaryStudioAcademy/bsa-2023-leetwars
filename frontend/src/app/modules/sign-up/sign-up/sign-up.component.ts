import { Component, OnInit } from '@angular/core';

@Component({
    selector: 'app-sign-up',
    templateUrl: './sign-up.component.html',
    styleUrls: ['./sign-up.component.sass'],
})
export class SignUpComponent implements OnInit {
    public showPassword: boolean;

    ngOnInit(): void {
        this.showPassword = false;
    }

    public togglePasswordVisibility() {
        this.showPassword = !this.showPassword;
    }
}
