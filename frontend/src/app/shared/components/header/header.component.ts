import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AuthService } from '@core/services/auth.service';
import { TabService } from '@core/services/tab.service';
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
export class HeaderComponent implements OnInit {
    public showMenu: boolean = false;

    tabs: ITab[] = [
        { title: 'Challenges', active: false, disabled: false, route: '' },
        { title: 'LeaderBoard', active: false, disabled: false, route: 'leader/board' },
    ];

    public user: IUser;

    constructor(private authService: AuthService, private router: Router, private tabService: TabService) {
        this.authService.getUser().subscribe((user) => {
            this.user = user;
        });
    }

    ngOnInit() {
        const defaultTab = this.tabs.find((tab) => tab.title === 'Challenges');
        const savedTab = this.tabService.getActiveTab();

        if (savedTab) {
            const tabToActivate = this.tabs.find((tab) => tab.route === savedTab);

            if (tabToActivate) {
                tabToActivate.active = true;
                this.router.navigate([tabToActivate.route]);
            }
        } else if (defaultTab) {
            defaultTab.active = true;
            this.router.navigate([defaultTab.route]);
        }
    }

    onTabClick(tab: ITab) {
        this.tabService.setActiveTab(tab.route);
        this.router.navigate([tab.route]);
    }

    public goToProfile() {
        this.showMenu = false;
        this.router.navigate(['/user/profile']);
    }
}
