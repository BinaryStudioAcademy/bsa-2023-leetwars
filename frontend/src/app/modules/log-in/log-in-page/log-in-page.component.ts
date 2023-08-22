import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { faEye, faEyeSlash } from '@fortawesome/free-solid-svg-icons';

@Component({
    selector: 'app-log-in-page',
    templateUrl: './log-in-page.component.html',
    styleUrls: ['./log-in-page.component.sass'],
})
export class LogInPageComponent implements OnInit {
    logInForm = new FormGroup({
        email: new FormControl('', [Validators.required, Validators.email]),
        password: new FormControl('', Validators.required),
    });

    showPassword: boolean = false;

    eyeIcon = faEyeSlash;

    isDataIncorrect: boolean;

    ngOnInit(): void {
        this.isDataIncorrect = false;
    }

    toggleShow() {
        this.showPassword = !this.showPassword;
        this.eyeIcon = this.showPassword ? faEye : faEyeSlash;
    }

    signIn() {
        this.isDataIncorrect = false;
    }
}
