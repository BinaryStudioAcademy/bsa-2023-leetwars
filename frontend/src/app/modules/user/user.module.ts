import { NgModule } from '@angular/core';
import { UserRoutingModule } from '@modules/user/user-routing.module';
import { SharedModule } from '@shared/shared.module';

import { ProfilePageMainInfoComponent } from './profile-page-main-info/profile-page-main-info.component';

@NgModule({
    declarations: [ProfilePageMainInfoComponent],
    imports: [SharedModule, UserRoutingModule],
})
export class UserModule {}
