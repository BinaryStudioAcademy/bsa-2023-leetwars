import { NgModule } from '@angular/core';
import { SubmissionsChartComponent } from '@modules/user/submissions-chart/submissions-chart.component';
import { UserRoutingModule } from '@modules/user/user-routing.module';
import { SharedModule } from '@shared/shared.module';

@NgModule({
    declarations: [SubmissionsChartComponent],
    imports: [SharedModule, UserRoutingModule],
})
export class UserModule { }
