import { Component } from '@angular/core';
import { AuthService } from '@core/services/auth.service';
import { UserService } from '@core/services/user.service';
import { UserFull } from '@shared/models/profile/user-full';
import { Subject } from 'rxjs';

@Component({
    selector: 'app-user-profile',
    templateUrl: './user-profile.component.html',
    styleUrls: ['./user-profile.component.sass'],
})
export class UserProfileComponent {
    user: UserFull = <UserFull>{};

    private unsubscribe$ = new Subject<void>();

    constructor(private userService: UserService, private authService: AuthService) {
        this.user.id = authService.isAuthorized()?.id ?? 0;
        userService.getFullUser(this.user.id).then((result) =>
            result.subscribe((u): void => {
                this.user = u;
            }));
    }
}
