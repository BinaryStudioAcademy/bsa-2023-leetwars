import { Component, OnInit } from '@angular/core';
import { AuthService } from '@core/services/auth.service';
import { ToastrNotificationsService } from '@core/services/toastr-notifications.service';
import { UserService } from '@core/services/user.service';
import { UserFull } from '@shared/models/profile/user-full';
import { User } from '@shared/models/user/user';
import { IUserSolutionsGroupedBySkillLevel as IUserSolutionsGroupedBySkillLevel } from '@shared/models/user/user-solutions-groupedby-skill-level-dto';
import { Subject, takeUntil } from 'rxjs';
import { IBar } from '../solved-problem/solved-problem.component';

@Component({
    selector: 'app-user-profile',
    templateUrl: './user-profile.component.html',
    styleUrls: ['./user-profile.component.sass'],
})
export class UserProfileComponent implements OnInit {
    user: UserFull = <UserFull>{};
    userSolutions: IUserSolutionsGroupedBySkillLevel[] = [];
    bars: IBar[] = [];
    private unsubscribe$ = new Subject<void>();

    constructor(
        private userService: UserService,
        private authService: AuthService,
        private toastrNotification: ToastrNotificationsService,
    ) {
        const user = <User>authService.isAuthorized();

        if (user) {
            this.user.id = user.id ?? 0;
        }
        userService
            .getFullUser(this.user.id)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe(
                (result) => {
                    this.user = result;
                },
                () => this.toastrNotification.showError('User not found'),
            );

        userService
            .getUserChallengesInfoByTags(this.user.id)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe(
                (result: IUserSolutionsGroupedBySkillLevel[]) => {
                    this.userSolutions = result;
                    this.bars = result.map((r) => ({
                        Label: r.name,
                        Done: r.taskCountDtos.length,
                        Total: r.totalCount,
                         
                    }));
                    
                               
                },
                () => this.toastrNotification.showError('Something went wrong'),
            );
    }
    ngOnInit(): void {}
}
