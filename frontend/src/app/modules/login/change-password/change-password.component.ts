import { Component, OnDestroy, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { BaseComponent } from '@core/base/base.component';
import { AuthService } from '@core/services/auth.service';
import { ToastrNotificationsService } from '@core/services/toastr-notifications.service';
import { UserManagementActions } from '@shared/constants/user-management-constants';
import { createCompareValidator } from '@shared/utils/validation/compare.validator';
import { passwordMaxLength, passwordMinLength } from '@shared/utils/validation/form-control-validator-options';
import { passwordPattern } from '@shared/utils/validation/regex-patterns';
import { getErrorMessage } from '@shared/utils/validation/validation-helper';
import { catchError, takeUntil } from 'rxjs';

@Component({
    selector: 'app-change-password',
    templateUrl: './change-password.component.html',
    styleUrls: ['./change-password.component.sass'],
})
export class ChangePasswordComponent extends BaseComponent implements OnInit, OnDestroy {
    resetPasswordForm = new FormGroup({
        password: new FormControl('', [
            Validators.required,
            Validators.minLength(passwordMinLength),
            Validators.maxLength(passwordMaxLength),
            Validators.pattern(passwordPattern),
        ]),
        confirmPassword: new FormControl(''),
    });

    private oobCode: string;

    constructor(
        private router: Router,
        private activatedRoute: ActivatedRoute,
        private authService: AuthService,
        private toastrService: ToastrNotificationsService,
    ) {
        super();
        this.addValidators();
    }

    ngOnInit() {
        this.activatedRoute.queryParams.pipe(takeUntil(this.unsubscribe$)).subscribe((params) => {
            if (!params || params['mode'] !== UserManagementActions.resetPassword) {
                this.router.navigate(['']);
            }
            this.oobCode = params['oobCode'];

            this.verifyPasswordResetCode(this.oobCode);
        });
    }

    changePassword() {
        this.authService
            .confirmPasswordReset(this.oobCode, this.resetPasswordForm.value.password!)
            .pipe(catchError(() => this.router.navigate([''])))
            .subscribe(() => {
                this.router.navigate(['auth/login']);
                this.toastrService.showSuccess('Password has been changed');
            });
    }

    getErrorMessage(formControlName: string) {
        return getErrorMessage(formControlName, this.resetPasswordForm);
    }

    private verifyPasswordResetCode(code: string) {
        this.authService
            .verifyPasswordResetCode(code)
            .pipe(catchError(() => this.router.navigate([''])))
            .subscribe();
    }

    private addValidators() {
        this.resetPasswordForm.addValidators(
            createCompareValidator(
                this.resetPasswordForm.get('password')!,
                this.resetPasswordForm.get('confirmPassword')!,
            ),
        );
    }
}
