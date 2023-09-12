import { Component, Input, OnChanges } from '@angular/core';
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

    @Input() userSolutions: IUserSolutionsGroupedBySkillLevel [] = [];

    public communityViews = 0;

    public communityLastWeekViews = 0;

    public communitySolution = 0;

    public communityLastWeekSolution = 0;

    public communityDiscuss = 0;

    public communityLastWeekDiscuss = 0;

    public communityLastWeekReputation = 0;

    public ngOnChanges() {
        this.updateSolutions();
    }

    private updateSolutions() {
        this.communityLastWeekSolution = utils.getLastWeekCount(this.user.solutions);
    }
}
