import { Component, OnInit } from '@angular/core';
import { BaseComponent } from '@core/base/base.component';
import { AuthService } from '@core/services/auth.service';
import { ToastrNotificationsService } from '@core/services/toastr-notifications.service';
import { UserService } from '@core/services/user.service';
import { IPageSettings } from '@shared/models/page-settings';
import { IUser } from '@shared/models/user/user';
import { takeUntil } from 'rxjs';

@Component({
    selector: 'app-leader-board',
    templateUrl: './leader-board.component.html',
    styleUrls: ['./leader-board.component.sass'],
})
export class LeaderBoardComponent extends BaseComponent implements OnInit {
    public users: IUser[] = [];

    public currentUser: IUser;

    public isLastPage = false;

    public loading = false;

    private page: IPageSettings = {
        pageNumber: 0,
        pageSize: 30,
    };

    constructor(
        private userService: UserService,
        private authService: AuthService,
        private toastrNotification: ToastrNotificationsService,
    ) {
        super();

        this.authService.getUser().subscribe((user: IUser) => {
            this.currentUser = user;
        });
    }

    public ngOnInit(): void {
        this.getUsers();
    }

    public onScroll() {
        if (this.isLastPage) {
            return;
        }

        this.getUsers();
    }

    private getUsers() {
        if (this.isLastPage) {
            return;
        }

        this.page.pageNumber++;
        this.loading = true;

        this.userService
            .getLeaderBoard(this.page)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe({
                next: (users) => {
                    this.loading = false;
                    if (!users.length) {
                        this.isLastPage = true;

                        return;
                    }
                    this.users = [...this.users, ...users];
                },
                error: () => {
                    this.loading = false;
                    this.toastrNotification.showError('Server connection error');
                },
            });
    }
}
