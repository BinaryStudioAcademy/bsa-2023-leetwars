import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { BaseComponent } from '@core/base/base.component';
import { AuthService } from '@core/services/auth.service';
import { ToastrNotificationsService } from '@core/services/toastr-notifications.service';
import { UserService } from '@core/services/user.service';
import { IUser } from '@shared/models/user/user';
import { IUserFull } from '@shared/models/user/user-full';
import { IUserSolutionsGroupedBySkillLevel } from '@shared/models/user/user-solutions-groupedby-skill-level';
import { firstValueFrom, takeUntil } from 'rxjs';

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

    isCurrentUser: Boolean = false;

    isFriend: Boolean = false;

    private user: IUser;

    currentUser?: IUser | null;

    constructor(
        private userService: UserService,
        private authService: AuthService,
        private toastrNotification: ToastrNotificationsService,
        private route: ActivatedRoute,
    ) {
        super();
        this.authService.getUser().subscribe((user: IUser) => {
            this.user = user;
        });
    }

    ngOnInit(): void {
        this.getCurrentUser();
    }

    private getUserInfo(id: number) {
        this.userService
            .getFullUser(id)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe({
                next: (result) => { 
                    this.user = result;
                    this.fullUser = result;
                 },
                error: () => { this.toastrNotification.showError('User not found'); },
            });
    }

    private getUserChallenges(id: number) {
        this.userService
            .getUserChallengesInfoByTags(id)
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

    private async getCurrentUser() {
        try {
            const result = await firstValueFrom(this.userService.getCurrentUser());
            this.currentUser = result;

            this.route.paramMap.subscribe((params) => {
                const userId = params.get('id') as unknown as number;

                if (userId !== null) {

                    this.isCurrentUser = this.currentUser?.id === userId;

                    if(!this.isCurrentUser)
                    {
                        this.getUserInfo(userId);
                        this.getUserChallenges(userId);
                    }
                    else
                    {
                        this.getUserInfo(this.user.id);
                        this.getUserChallenges(this.user.id);
                    }
                }
                else {
                    this.isCurrentUser = true;
                    this.getUserInfo(this.user.id);
                    this.getUserChallenges(this.user.id);
                }

            })

        }   catch (error) {
            this.toastrNotification.showError('User not found');
        }
    }
}
