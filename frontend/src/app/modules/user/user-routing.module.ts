import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { NotFoundComponent } from '@shared/components/not-found/not-found.component';

import { ProfilePageMainInfoComponent } from './profile-page-main-info/profile-page-main-info.component';

const routes: Routes = [
    {
        path: 'profile',
        component: ProfilePageMainInfoComponent,
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
export class UserRoutingModule {}
