import { Component, OnInit } from '@angular/core';
import { AuthService } from '@core/services/auth.service';
import { ToastrNotificationsService } from '@core/services/toastr-notifications.service';
import { UserService } from '@core/services/user.service';
import { IUserFull } from '@shared/models/profile/user-full';
import { IUser } from '@shared/models/user/user';
import { IUserSolutionsGroupedBySkillLevel } from '@shared/models/user/user-solutions-groupedby-skill-level';
import { Subject, takeUntil } from 'rxjs';

import { IBar } from '../solved-problem/solved-problem.component';

import { getInactiveBars } from './user-profile.utils';

@Component({
    selector: 'app-user-profile',
    templateUrl: './user-profile.component.html',
    styleUrls: ['./user-profile.component.sass'],
})
export class UserProfileComponent implements OnInit {
    user?: IUser | null;

    fullUser: IUserFull;

    userSolutions: IUserSolutionsGroupedBySkillLevel[] = [];

    bars: IBar[] = [];

    private unsubscribe$ = new Subject<void>();

    constructor(
        private userService: UserService,
        private authService: AuthService,
        private toastrNotification: ToastrNotificationsService,
    ) {
        this.user = this.authService.isAuthorized();
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
                next: (result) => { this.fullUser = result; },
                error: () => { this.toastrNotification.showError('User not found'); },
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
                error: () => { this.toastrNotification.showError('Server connection error'); },
            });
    }
}
