import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { ChallengeCreationComponent } from './challenge-creation/challenge-creation.component';
import { OnlineEditorPageComponent } from './online-editor-page/online-editor-page.component';

const routes: Routes = [
    {
        path: 'create',
        component: ChallengeCreationComponent,
    },
    {
        path: 'edit/:id',
        component: ChallengeCreationComponent,
    },
    {
        path: ':id',
        component: OnlineEditorPageComponent,
    },
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule],
})
export class ChallengesRoutingModule {}
