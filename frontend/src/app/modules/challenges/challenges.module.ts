import { NgModule } from '@angular/core';
import { SharedModule } from '@shared/shared.module';

import { ChallengesDropdownSelectComponent } from './challenges-dropdown-select/challenges-dropdown-select.component';
import { ChallengesTestPageComponent } from './challenges-test-page/challenges-test-page.component';
import { EditorQuestionComponent } from './editor-question/editor-question.component';
import { StepsOfProgressComponent } from './steps-of-progress/steps-of-progress.component';
import { ChallengesRoutingModule } from './challenges-routing.module';

@NgModule({
    declarations: [
        StepsOfProgressComponent,
        ChallengesTestPageComponent,
        ChallengesDropdownSelectComponent,
        EditorQuestionComponent,
    ],
    imports: [SharedModule, ChallengesRoutingModule],
})
export class ChallengesModule {}