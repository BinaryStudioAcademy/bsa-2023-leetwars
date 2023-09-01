import { Component, Input, OnChanges } from '@angular/core';
import * as utils from '@modules/user/profile-page-main-info/profile-page-main.utils';
import { LanguageLevel } from '@shared/enums/languageLevel';
import { UserFull } from '@shared/models/profile/user-full';
import { UserLanguageLevel } from '@shared/models/profile/user-language-level';
import * as moment from 'moment/moment';

@Component({
    selector: 'app-profile-page-main-info',
    templateUrl: './profile-page-main-info.component.html',
    styleUrls: ['./profile-page-main-info.component.sass'],
})
export class ProfilePageMainInfoComponent implements OnChanges {
    @Input() user: UserFull = <UserFull>{};

    //replace it with real user interface
    LanguageLevel = LanguageLevel;

    public username? = '';

    public languages? = '';

    public userRank = '';

    public communityViews = 0;

    public communityLastWeekViews = 0;

    public communitySolution = 0;

    public communityLastWeekSolution = 0;

    public communityDiscuss = 0;

    public communityLastWeekDiscuss = 0;

    public communityReputation = 0;

    public communityLastWeekReputation = 0;

    ngOnChanges(): void {
        this.updateSolutions();
    }

    private updateSolutions() {
        this.communityLastWeekSolution = utils.getLastWeekCount(this.user.solutions);
    }
}
