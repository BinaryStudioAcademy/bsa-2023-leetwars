import { Component, Input, OnChanges } from '@angular/core';
import { UserFull } from '@shared/models/profile/user-full';

@Component({
    selector: 'app-profile-page-main-info',
    templateUrl: './profile-page-main-info.component.html',
    styleUrls: ['./profile-page-main-info.component.sass'],
})
export class ProfilePageMainInfoComponent implements OnChanges {
    @Input() user: UserFull = <UserFull>{};

    //replace it with real user interface
    ngOnChanges(): void {
        this.updateView();
    }

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

    private updateView() {
        this.username = this.user.userName;
        this.languages = this.user.preferredLanguages?.join(', ');
        this.userRank = this.user.totalScore.toString();
        this.communitySolution = this.user.solutions.length;
    }
}
