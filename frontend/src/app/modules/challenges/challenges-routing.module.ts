import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { ChallengesTestPageComponent } from './challenges-test-page/challenges-test-page.component';

const routes: Routes = [
    {
        path: '',
        component: ChallengesTestPageComponent,
    },
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule],
})
export class ChallengesRoutingModule {}
