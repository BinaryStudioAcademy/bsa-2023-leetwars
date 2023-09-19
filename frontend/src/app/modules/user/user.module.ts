import { NgModule } from '@angular/core';
import { SubmissionsChartComponent } from '@modules/user/submissions-chart/submissions-chart.component';
import { UserRoutingModule } from '@modules/user/user-routing.module';
import { SharedModule } from '@shared/shared.module';
import { ProgressbarModule } from 'ngx-bootstrap/progressbar';

import { ProfilePageMainInfoComponent } from './profile-page-main-info/profile-page-main-info.component';
import { SolvedProblemComponent } from './solved-problem/solved-problem.component';
import { UserInfoEditorComponent } from './user-info-editor/user-info-editor.component';
import { UserProfileComponent } from './user-profile/user-profile.component';

@NgModule({
    declarations: [
        SubmissionsChartComponent,
        ProfilePageMainInfoComponent,
        SolvedProblemComponent,
        UserProfileComponent,
        UserInfoEditorComponent,
    ],
    imports: [SharedModule, UserRoutingModule, ProgressbarModule],
})
export class UserModule {}
