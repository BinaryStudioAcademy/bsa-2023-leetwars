import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { AuthService } from '@core/services/auth.service';
import { ToastrNotificationsService } from '@core/services/toastr-notifications.service';
import { UserService } from '@core/services/user.service';
import { AssetConstants } from '@shared/constants/asset-constants';
import { IEditUserInfo } from '@shared/models/user/edit-user-info';
import { IUser } from '@shared/models/user/user';
import { validatePictureFileName } from '@shared/utils/validation/file-validation-helper';
import {
    emailMaxLength,
    userNameMaxLength,
    userNameMinLength,
} from '@shared/utils/validation/form-control-validator-options';
import { emailPattern, latinOrCyrillicCharactersPattern } from '@shared/utils/validation/regex-patterns';
import { getErrorMessage } from '@shared/utils/validation/validation-helper';
import { map, of, switchMap } from 'rxjs';

@Component({
    selector: 'app-user-info-editor',
    templateUrl: './user-info-editor.component.html',
    styleUrls: ['./user-info-editor.component.sass'],
})
export class UserInfoEditorComponent implements OnInit {
    userInfoForm: FormGroup = new FormGroup({
        email: new FormControl('', [
            Validators.required,
            Validators.maxLength(emailMaxLength),
            Validators.pattern(emailPattern),
        ]),
        username: new FormControl('', [
            Validators.required,
            Validators.minLength(userNameMinLength),
            Validators.maxLength(userNameMaxLength),
            Validators.pattern(latinOrCyrillicCharactersPattern),
        ]),
        avatar: new FormControl<File>(null!),
    });

    avatarPreview: string;

    user: IUser;

    constructor(
        private userService: UserService,
        private authService: AuthService,
        private toastrNotification: ToastrNotificationsService,
        private router: Router,
    ) {}

    ngOnInit(): void {
        this.loadData();
    }

    public onSave() {
        const editUserInfo: IEditUserInfo = {
            email: this.userInfoForm.value.email,
            username: this.userInfoForm.value.username,
        };

        this.authService
            .updateUserInfo(editUserInfo)
            .pipe(switchMap((user) => (this.userInfoForm.value.avatar ? this.updateUserAvatar(user) : of(user))))
            .subscribe({
                next: (user) => {
                    this.authService.setUserInfo(user);
                    this.toastrNotification.showSuccess('User information has been updated');
                },
                error: () => {
                    this.toastrNotification.showError('Something went wrong');
                },
            });
    }

    public onImagePicked(event: Event) {
        const file = (event.target as HTMLInputElement).files![0];

        if (!validatePictureFileName(file.name)) {
            return;
        }

        this.userInfoForm.patchValue({ avatar: file });

        this.updateAvatarPreview(event.target as HTMLInputElement);
    }

    onReturnToProfile() {
        this.router.navigate(['user/profile']);
    }

    public getErrorMessage(formControlName: string) {
        return getErrorMessage(formControlName, this.userInfoForm);
    }

    private updateUserAvatar(user: IUser) {
        const fileFormData = new FormData();

        fileFormData.append('avatar', this.userInfoForm.value.avatar);

        return this.userService.updateUserAvatar(fileFormData).pipe(
            map((avatar) => {
                user.imagePath = avatar.imagePath;

                return user;
            }),
        );
    }

    private loadData() {
        this.userService.getCurrentUser().subscribe((user) => {
            this.user = user;
            this.initializeForm(user);
            this.avatarPreview = this.user?.imagePath ?? AssetConstants.defaultProfileImagePath;
        });
    }

    private initializeForm(user: IUser) {
        this.userInfoForm.patchValue({
            email: user!.email,
            username: user!.userName,
        });
    }

    private updateAvatarPreview(target: HTMLInputElement) {
        const file = target.files && target.files[0];

        if (!file) {
            return;
        }

        const reader = new FileReader();

        reader.onload = () => {
            this.avatarPreview = reader.result as string;
        };

        reader.readAsDataURL(file);
    }
}
