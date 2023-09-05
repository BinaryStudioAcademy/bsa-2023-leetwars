import { NgModule } from '@angular/core';
import { SharedModule } from '@shared/shared.module';

import { ChallengesDropdownSelectComponent } from './challenges-dropdown-select/challenges-dropdown-select.component';
import { ChallengesTestPageComponent } from './challenges-test-page/challenges-test-page.component';
import { EditorQuestionComponent } from './editor-question/editor-question.component';
import { SolutionPageComponent } from './solution-page/solution-page.component';
import { StepsOfProgressComponent } from './steps-of-progress/steps-of-progress.component';
import { ChallengesRoutingModule } from './challenges-routing.module';
import { ChallengeCreationComponent } from './challenge-creation/challenge-creation.component';

@NgModule({
    declarations: [
        StepsOfProgressComponent,
        ChallengesTestPageComponent,
        ChallengesDropdownSelectComponent,
        EditorQuestionComponent,
        SolutionPageComponent,
        ChallengeCreationComponent,
    ],
    imports: [SharedModule, ChallengesRoutingModule],
})
export class ChallengesModule {}
