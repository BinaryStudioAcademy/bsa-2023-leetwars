import { NgModule } from '@angular/core';
import { SharedModule } from '@shared/shared.module';

import { ChallengesDropdownSelectComponent } from './challenges-dropdown-select/challenges-dropdown-select.component';
import { ChallengesTestPageComponent } from './challenges-test-page/challenges-test-page.component';
import { ChallengesRoutingModule } from './challenges-routing.module';

@NgModule({
    declarations: [ChallengesTestPageComponent, ChallengesDropdownSelectComponent],
    imports: [SharedModule, ChallengesRoutingModule],
})
export class ChallengesModule {}
