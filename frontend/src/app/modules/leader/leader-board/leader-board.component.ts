import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { BaseComponent } from '@core/base/base.component';
import { ToastrNotificationsService } from '@core/services/toastr-notifications.service';
import { UserService } from '@core/services/user.service';
import { IPageSettings } from '@shared/models/page-settings';
import { IUser } from '@shared/models/user/user';
import { Subject, takeUntil } from 'rxjs';

@Component({
    selector: 'app-leader-board',
    templateUrl: './leader-board.component.html',
    styleUrls: ['./leader-board.component.sass'],
})
export class LeaderBoardComponent extends BaseComponent implements OnInit {
    public users: IUser[] = [];

    public currentUser: IUser;

    public usersToShow: IUser[] = [];

    public isLastPage = false;

    public loading = false;

    public scrollEventSubject = new Subject<void>();

    private page: IPageSettings = {
        pageNumber: 0,
        pageSize: 30,
    };

    constructor(
        private userService: UserService,
        private toastrNotification: ToastrNotificationsService,
        private router: Router,
    ) {
        super();
    }

    public ngOnInit(): void {
        this.getUsers();
    }

    public onScroll() {
        this.scrollEventSubject.next();

        if (this.isLastPage) {
            return;
        }

        this.getUsers();
    }

    public onLinkClick(nickname: string | undefined) {
        this.router.navigate(['/user/profile', nickname as string]);
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
                    this.usersToShow = this.users;
                },
                error: () => {
                    this.loading = false;
                    this.toastrNotification.showError('Server connection error');
                },
            });
    }
}
