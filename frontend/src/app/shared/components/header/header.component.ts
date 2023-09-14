import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { AuthService } from '@core/services/auth.service';
import { IUser } from '@shared/models/user/user';

@Component({
    selector: 'app-header',
    templateUrl: './header.component.html',
    styleUrls: ['./header.component.sass'],
})
export class HeaderComponent {
    public showMenu: boolean = false;

    public user: IUser;

    constructor(private authService: AuthService, private router: Router) {
        this.authService.getUser().subscribe((user) => {
            this.user = user;
        });
    }

    public goToProfile() {
        this.showMenu = false;
        this.router.navigate(['/user/profile']);
    }
}
