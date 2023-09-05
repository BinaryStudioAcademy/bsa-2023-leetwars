import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ChallengeCreationComponent } from '@modules/challenges/challenge-creation/challenge-creation.component';

import { ChallengesTestPageComponent } from './challenges-test-page/challenges-test-page.component';
import { EditorQuestionComponent } from './editor-question/editor-question.component';

const routes: Routes = [
    {
        path: 'create',
        component: ChallengeCreationComponent,
    },
    {
        path: 'test',
        component: ChallengesTestPageComponent,
    },
    {
        path: 'question',
        component: EditorQuestionComponent,
    },
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule],
})
export class ChallengesRoutingModule {}
