import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ChallengeCreationComponent } from '@modules/challenges/challenge-creation/challenge-creation.component';

const routes: Routes = [
    {
        path: 'create',
        component: ChallengeCreationComponent,
    },
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule],
})
export class ChallengesRoutingModule {}
