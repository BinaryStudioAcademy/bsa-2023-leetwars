import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { AuthService } from '@core/services/auth.service';
import { ToastrNotificationsService } from '@core/services/toastr-notifications.service';
import { UserService } from '@core/services/user.service';

@Component({
    selector: 'app-log-in-page',
    templateUrl: './log-in-page.component.html',
    styleUrls: ['./log-in-page.component.sass'],
})
export class LogInPageComponent implements OnInit {
    //TODO: Add real validation and don't forget to add it in html file
    logInForm = new FormGroup({
        email: new FormControl('', [Validators.required, Validators.email]),
        password: new FormControl('', Validators.required),
    });

    isExistingEmail = true;

    showPassword: boolean = false;

    isDataIncorrect: boolean;

    constructor(
        private authService: AuthService,
        private router: Router,
        private userService: UserService,
        private toastrNotification: ToastrNotificationsService,
    ) {}

    ngOnInit(): void {
        this.isDataIncorrect = false;
    }

    toggleShow() {
        this.showPassword = !this.showPassword;
    }

    public signIn() {
        this.authService.login(this.logInForm.value.email!, this.logInForm.value.password!).subscribe(
            () => {
                this.router.navigateByUrl('/main');
            },
            (error) => {
                this.toastrNotification.showError('Something went wrong');
                console.error('Error :', error);
            },
        );
    }
}
