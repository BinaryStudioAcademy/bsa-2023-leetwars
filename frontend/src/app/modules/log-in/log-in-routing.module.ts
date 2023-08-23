import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { NotFoundComponent } from '@shared/components/not-found/not-found.component';

import { LogInPageComponent } from './log-in-page/log-in-page.component';

const routes: Routes = [
    {
        path: '',
        component: LogInPageComponent,
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
export class LogInRoutingModule {}
