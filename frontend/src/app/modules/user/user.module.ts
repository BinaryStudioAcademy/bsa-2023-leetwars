import { NgModule } from '@angular/core';
import { SubmissionsChartComponent } from '@modules/user/submissions-chart/submissions-chart.component';
import { UserRoutingModule } from '@modules/user/user-routing.module';
import { SharedModule } from '@shared/shared.module';
import { NgxChartsModule } from '@swimlane/ngx-charts';
import { ProgressbarModule } from 'ngx-bootstrap/progressbar';
import { CarouselModule } from 'ngx-owl-carousel-o';

import { BadgeComponent } from './badge/badge.component';
import { ProfilePageMainInfoComponent } from './profile-page-main-info/profile-page-main-info.component';
import { SolvedProblemComponent } from './solved-problem/solved-problem.component';
import { UserInfoEditorComponent } from './user-info-editor/user-info-editor.component';
import { UserProfileComponent } from './user-profile/user-profile.component';

@NgModule({
    declarations: [
        SubmissionsChartComponent,
        ProfilePageMainInfoComponent,
        SolvedProblemComponent,
        BadgeComponent,
        UserProfileComponent,
        UserInfoEditorComponent,
    ],
    imports: [SharedModule, UserRoutingModule, NgxChartsModule, ProgressbarModule, CarouselModule],
})
export class UserModule {}
