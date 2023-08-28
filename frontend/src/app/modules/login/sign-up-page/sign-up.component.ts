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
    //TODO: Add real validation and don't forget to add it in html file
    registrationForm = new FormGroup({
        email: new FormControl('', [Validators.required, Validators.email]),
        username: new FormControl('', [Validators.required]),
        password: new FormControl('', [Validators.required]),
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
