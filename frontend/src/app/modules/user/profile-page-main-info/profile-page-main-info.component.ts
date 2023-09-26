import { Component, Input, OnChanges, SimpleChanges } from '@angular/core';
import { Router } from '@angular/router';
import * as utils from '@modules/user/profile-page-main-info/profile-page-main.utils';
import { IUserFull } from '@shared/models/user/user-full';
import { IUserSolutionsGroupedBySkillLevel } from '@shared/models/user/user-solutions-groupedby-skill-level';

@Component({
    selector: 'app-profile-page-main-info',
    templateUrl: './profile-page-main-info.component.html',
    styleUrls: ['./profile-page-main-info.component.sass'],
})
export class ProfilePageMainInfoComponent implements OnChanges {
    @Input() user: IUserFull = <IUserFull>{};

    @Input() userSolutions: IUserSolutionsGroupedBySkillLevel[] = [];

    communityViews = 0;

    communityLastWeekViews = 0;

    communitySolution = 0;

    communityLastWeekSolution = 0;

    communityDiscuss = 0;

    communityLastWeekDiscuss = 0;

    communityLastWeekReputation = 0;

    constructor(private router: Router) {}

    ngOnChanges({ user }: SimpleChanges) {
        if (user && this.user) {
            this.updateSolutions();
        }
    }

    onEditProfile() {
        this.router.navigate(['user/profile/edit']);
    }

    private updateSolutions() {
        this.communityLastWeekSolution = utils.getLastWeekCount(this.user.solutions);
    }
}
