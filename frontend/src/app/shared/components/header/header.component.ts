import { Component } from '@angular/core';
import { AuthService } from '@core/services/auth.service';
import { IUser } from '@shared/models/user/user';

@Component({
    selector: 'app-header',
    templateUrl: './header.component.html',
    styleUrls: ['./header.component.sass'],
})
export class HeaderComponent {
    showMenu: boolean = false;

    user: IUser;

    constructor(private authService: AuthService) {
        this.authService.getUser().subscribe((user) => {
            this.user = user;
        });
    }
}
