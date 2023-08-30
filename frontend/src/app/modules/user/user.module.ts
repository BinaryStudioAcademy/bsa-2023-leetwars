import { NgModule } from '@angular/core';
import { UserService } from '@core/services/user.service';
import { SubmissionsChartComponent } from '@modules/user/submissions-chart/submissions-chart.component';
import { UserRoutingModule } from '@modules/user/user-routing.module';
import { UserFull } from '@shared/models/profile/user-full';
import { SharedModule } from '@shared/shared.module';
import { ProgressbarModule } from 'ngx-bootstrap/progressbar';

import { ProfilePageMainInfoComponent } from './profile-page-main-info/profile-page-main-info.component';
import { SolvedProblemComponent } from './solved-problem/solved-problem.component';
import { UserProfileComponent } from './user-profile/user-profile.component';

@NgModule({
    declarations: [
        SubmissionsChartComponent,
        ProfilePageMainInfoComponent,
        SolvedProblemComponent,
        UserProfileComponent,
    ],
    imports: [SharedModule, UserRoutingModule, ProgressbarModule],
})
export class UserModule {
    user: UserFull = <UserFull>{};

    constructor(private userService: UserService) {
        userService.getFullUser(2).subscribe((u: UserFull) => {
            this.user = u;
        });
    }
}
