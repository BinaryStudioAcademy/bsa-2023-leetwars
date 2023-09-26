import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { UnsavedChangesGuard } from '@core/guards/unsaved-changes.guard';

import { ChallengeCreationComponent } from './challenge-creation/challenge-creation.component';
import { OnlineEditorPageComponent } from './online-editor-page/online-editor-page.component';

const routes: Routes = [
    {
        path: 'create',
        component: ChallengeCreationComponent,
        canDeactivate: [UnsavedChangesGuard],
    },
    {
        path: 'edit/:id',
        component: ChallengeCreationComponent,
        canDeactivate: [UnsavedChangesGuard],
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
