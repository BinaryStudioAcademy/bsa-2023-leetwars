import { Component } from '@angular/core';
import { AuthService } from '@core/services/auth.service';
import { ToastrNotificationsService } from '@core/services/toastr-notifications.service';
import { UserService } from '@core/services/user.service';
import { UserFull } from '@shared/models/profile/user-full';
import { User } from '@shared/models/user';
import { Subject, takeUntil } from 'rxjs';

@Component({
    selector: 'app-user-profile',
    templateUrl: './user-profile.component.html',
    styleUrls: ['./user-profile.component.sass'],
})
export class UserProfileComponent {
    user: UserFull = <UserFull>{};

    private unsubscribe$ = new Subject<void>();

    constructor(
        private userService: UserService,
        private authService: AuthService,
        private toastrNotification: ToastrNotificationsService,
    ) {
        const user = <User>authService.isAuthorized();

        if (user) {
            this.user.id = user.id ?? 0;
        }
        this.user.id = 3;
        userService
            .getFullUser(this.user.id)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe(
                (result) => {
                    this.user = result;
                },
                () => this.toastrNotification.showError('User not found'),
            );
    }
}
