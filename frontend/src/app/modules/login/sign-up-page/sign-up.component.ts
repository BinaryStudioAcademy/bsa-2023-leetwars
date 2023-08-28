import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { AuthService } from '@core/services/auth.service';

@Component({
    selector: 'app-sign-up',
    templateUrl: './sign-up.component.html',
    styleUrls: ['./sign-up.component.sass'],
})
export class SignUpComponent {
    registrationForm = new FormGroup({
        email: new FormControl('', [Validators.required, Validators.email]),
        username: new FormControl('', [
            Validators.required,
            Validators.minLength(2),
            Validators.maxLength(50),
            Validators.pattern('^[A-Za-z\\s-]+$'),
        ]),
        password: new FormControl('', [
            Validators.required,
            Validators.minLength(8),
            Validators.maxLength(32),
            Validators.pattern('^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9]).{8,32}$'),
        ]),
    });

    constructor(private authService: AuthService, private router: Router) {}

    public signUp() {
        this.authService
            .register(
                this.registrationForm.value.username!,
                this.registrationForm.value.email!,
                this.registrationForm.value.password!,
            )
            .subscribe(() => {
                this.router.navigateByUrl('');
            });
    }
}
