import { NgModule } from '@angular/core';
import { SharedModule } from '@shared/shared.module';

import { LandingPageComponent } from './landing-page/landing-page.component';
import { LandingRoutingModule } from './landing-routing.module';
import { UserModule } from '@modules/user/user.module';


@NgModule({
    declarations: [LandingPageComponent],
    imports: [SharedModule, LandingRoutingModule, UserModule],
})
export class LandingModule {}
