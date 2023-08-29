import { NgModule } from '@angular/core';
import { SubmissionsChartComponent } from '@modules/user/submissions-chart/submissions-chart.component';
import { UserRoutingModule } from '@modules/user/user-routing.module';
import { SharedModule } from '@shared/shared.module';

import { ProfilePageMainInfoComponent } from './profile-page-main-info/profile-page-main-info.component';

@NgModule({
    declarations: [SubmissionsChartComponent, ProfilePageMainInfoComponent],
    imports: [SharedModule, UserRoutingModule],
})
export class UserModule {}
