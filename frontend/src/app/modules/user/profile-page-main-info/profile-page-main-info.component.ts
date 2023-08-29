import { Component } from '@angular/core';
import { UserService } from '@core/services/user.service';

@Component({
    selector: 'app-profile-page-main-info',
    templateUrl: './profile-page-main-info.component.html',
    styleUrls: ['./profile-page-main-info.component.sass'],
})
export class ProfilePageMainInfoComponent {
    constructor(private userService: UserService) {}
    //replace it with real user interface
    public username = 'TatiHutii';

    public userRank = '~5,000,000';

    public communityViews = 0;

    public communityLastWeekViews = 0;

    public communitySolution = 0;

    public communityLastWeekSolution = 0;

    public communityDiscuss = 0;

    public communityLastWeekDiscuss = 0;

    public communityReputation = 0;

    public communityLastWeekReputation = 0;
}
