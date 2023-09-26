import { Component, OnInit } from '@angular/core';
import { BaseComponent } from '@core/base/base.component';
import { AuthService } from '@core/services/auth.service';
import { ToastrNotificationsService } from '@core/services/toastr-notifications.service';
import { UserService } from '@core/services/user.service';
import { IUser } from '@shared/models/user/user';
import { IUserFull } from '@shared/models/user/user-full';
import { IUserSolutionsGroupedBySkillLevel } from '@shared/models/user/user-solutions-groupedby-skill-level';
import { takeUntil } from 'rxjs';

import { IBar } from '../solved-problem/solved-problem.component';
import { getInactiveBars } from './user-profile.utils';

@Component({
    selector: 'app-user-profile',
    templateUrl: './user-profile.component.html',
    styleUrls: ['./user-profile.component.sass'],
})
export class UserProfileComponent extends BaseComponent implements OnInit {
    fullUser: IUserFull;

    userSolutions: IUserSolutionsGroupedBySkillLevel[] = [];

    bars: IBar[] = [];

    private user: IUser;

    constructor(
        private userService: UserService,
        private authService: AuthService,
        private toastrNotification: ToastrNotificationsService,
    ) {
        super();
        this.authService.getUser().subscribe((user: IUser) => {
            this.user = user;
        });
    }

    ngOnInit(): void {
        this.getUserInfo();
        this.getUserChallenges();
    }

    private getUserInfo() {
        this.userService
            .getFullUser(this.user!.id)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe({
                next: (result) => {
                    this.fullUser = result;
                },
                error: () => {
                    this.toastrNotification.showError('User not found');
                },
            });
    }

    private getUserChallenges() {
        this.userService
            .getUserChallengesInfoByTags(this.user!.id)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe({
                next: (result: IUserSolutionsGroupedBySkillLevel[]) => {
                    this.userSolutions = result;
                    this.bars = [
                        ...result.map((r) => ({
                            Label: r.name,
                            Done: r.taskCountDtos.length,
                            Total: r.totalCount,
                        })),
                        ...getInactiveBars(result),
                    ];
                },
                error: () => {
                    this.toastrNotification.showError('Server connection error');
                },
            });
    }
}
