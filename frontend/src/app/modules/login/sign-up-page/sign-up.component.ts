import { Component } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { AuthService } from '@core/services/auth.service';

@Component({
    selector: 'app-sign-up',
    templateUrl: './sign-up.component.html',
    styleUrls: ['./sign-up.component.sass'],
})
export class SignUpComponent {
    public showPassword = false;

    signUpForm = new FormGroup({
        email: new FormControl(''),
        username: new FormControl(''),
        password: new FormControl(''),
    });

    constructor(private authService: AuthService, private router: Router) {}

    public togglePasswordVisibility() {
        this.showPassword = !this.showPassword;
    }

    public onSignUp() {
        this.authService
            .register(this.signUpForm.value.username!, this.signUpForm.value.email!, this.signUpForm.value.password!)
            .subscribe(() => {
                this.router.navigateByUrl('');
            });
    }
}
