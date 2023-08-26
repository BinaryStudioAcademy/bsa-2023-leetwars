import { NgModule } from '@angular/core';
import { UserRoutingModule } from '@modules/user/user-routing.module';
import { SharedModule } from '@shared/shared.module';
import { ProgressbarModule } from 'ngx-bootstrap/progressbar';

import { ProfilePageMainInfoComponent } from './profile-page-main-info/profile-page-main-info.component';
import { SolvedProblemComponent } from './solved-problem/solved-problem.component';

@NgModule({
    declarations: [ProfilePageMainInfoComponent, SolvedProblemComponent],
    imports: [SharedModule, UserRoutingModule, ProgressbarModule],
    exports: [SolvedProblemComponent],
})
export class UserModule {}
