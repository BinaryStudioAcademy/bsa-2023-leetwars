import { Component } from '@angular/core';
import { AuthService } from '@core/services/auth.service';
import { ToastrNotificationsService } from '@core/services/toastr-notifications.service';
import { UserService } from '@core/services/user.service';
import { UserFull } from '@shared/models/profile/user-full';
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
        this.user.id = authService.isAuthorized()?.id ?? 0;
        userService
            .getFullUser(1)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe(
                (result) => {
                    this.user = result;
                },
                () => this.toastrNotification.showError('User not found'),
            );
    }
}
