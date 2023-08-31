import { Component } from '@angular/core';
import { UserService } from '@core/services/user.service';
import { UserFull } from '@shared/models/profile/user-full';

@Component({
    selector: 'app-user-profile',
    templateUrl: './user-profile.component.html',
    styleUrls: ['./user-profile.component.sass'],
})
export class UserProfileComponent {
    user: UserFull = <UserFull>{};

    constructor(private userService: UserService) {
        userService.getFullUser(2).subscribe((u): void => {
            this.user = u;
        });
    }
}
