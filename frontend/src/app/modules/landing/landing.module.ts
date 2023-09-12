import { NgModule } from '@angular/core';
import { ScrollToDirective } from '@core/directives/scroll-to.directive';
import { SharedModule } from '@shared/shared.module';

import { LandingPageComponent } from './landing-page/landing-page.component';
import { LandingRoutingModule } from './landing-routing.module';

@NgModule({
    declarations: [LandingPageComponent, ScrollToDirective],
    imports: [SharedModule, LandingRoutingModule],
})
export class LandingModule {}
