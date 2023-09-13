import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { AuthService } from '@core/services/auth.service';
import { IUser } from '@shared/models/user/user';

interface ITab {
    title: string;
    active: boolean;
    disabled: boolean;
    route: string;
}

@Component({
    selector: 'app-header',
    templateUrl: './header.component.html',
    styleUrls: ['./header.component.sass'],
})
export class HeaderComponent {
    showMenu: boolean = false;

    tabs: ITab[] = [
        { title: 'Challenges', active: false, disabled: false, route: '/challenges' },
        { title: 'LeaderBoard', active: false, disabled: false, route: '/leader/board' },
    ];

    user: IUser;

    constructor(private authService: AuthService, private router: Router) {
        this.authService.getUser().subscribe((user) => {
            this.user = user;
        });
    }

    onTabClick(tab: ITab) {
        this.router.navigate([tab.route]);
    }
}
