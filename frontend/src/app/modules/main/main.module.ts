import { NgModule } from '@angular/core';
import { SharedModule } from '@shared/shared.module';

import { ChallengeComponent } from './challenge/challenge.component';
import { FilteringSectionComponent } from './filtering-section/filtering-section.component';
import { MainComponent } from './main-page/main-page.component';
import { SuggestedChallengeComponent } from './suggested-challenge/suggested-challenge.component';
import { MainRoutingModule } from './main-routing.module';

@NgModule({
    declarations: [MainComponent, SuggestedChallengeComponent, FilteringSectionComponent, ChallengeComponent],
    imports: [SharedModule, MainRoutingModule],
})
export class MainModule {}
