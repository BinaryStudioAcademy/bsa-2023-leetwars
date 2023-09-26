import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { ToastrNotificationsService } from '@core/services/toastr-notifications.service';
import { IUser } from '@shared/models/user/user';
import {
    userNameMaxLength,
    userNameMinLength,
} from '@shared/utils/validation/form-control-validator-options';

@Component({
    selector: 'app-user-preferences',
    templateUrl: './user-preferences.component.html',
    styleUrls: ['./user-preferences.component.sass'],
})
export class UserPreferencesComponent {
    userInfoForm: FormGroup = new FormGroup({
        email: new FormControl(''),
        username: new FormControl('', [
            Validators.required,
            Validators.minLength(userNameMinLength),
            Validators.maxLength(userNameMaxLength),
        ]),
        avatar: new FormControl<File>(null!),
    });

    user: IUser;

    constructor(
        private toastrNotification: ToastrNotificationsService,
    ) {}
}
