import { Component, Input, OnChanges } from '@angular/core';
import { UserFull } from '@shared/models/profile/user-full';
import * as moment from 'moment/moment';

@Component({
    selector: 'app-profile-page-main-info',
    templateUrl: './profile-page-main-info.component.html',
    styleUrls: ['./profile-page-main-info.component.sass'],
})
export class ProfilePageMainInfoComponent implements OnChanges {
    @Input() user: UserFull = <UserFull>{};

    //replace it with real user interface
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
        this.updateView();
    }

    private updateView() {
        if (this.user.solutions) {
            this.communityLastWeekSolution = this.user.solutions?.filter(
                (solution) =>
                    new Date(solution.submittedAt!).getTime() >
                        new Date(moment().subtract(1, 'weeks').startOf('isoWeek').format('YYYY-MM-DD')).getTime() &&
                    new Date(solution.submittedAt!).getTime() <
                        new Date(moment().subtract(1, 'weeks').endOf('isoWeek').format('YYYY-MM-DD')).getTime(),
            ).length;
        }
    }
}
