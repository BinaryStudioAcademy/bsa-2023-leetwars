import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { NotFoundComponent } from '@shared/components/not-found/not-found.component';

import { LeaderBoardComponent } from './leader-board/leader-board.component';

const routes: Routes = [
    {
        path: 'board',
        component: LeaderBoardComponent,
        children: [
            {
                path: '**',
                component: NotFoundComponent,
                pathMatch: 'full',
            },
        ],
    },
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule],
})
export class LeaderRoutingModule {}
