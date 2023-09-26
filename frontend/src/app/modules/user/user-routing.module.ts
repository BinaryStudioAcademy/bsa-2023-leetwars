import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { UserInfoEditorComponent } from './user-info-editor/user-info-editor.component';
import { UserProfileComponent } from './user-profile/user-profile.component';

const routes: Routes = [
    {
        path: 'profile',
        component: UserProfileComponent,
    },
    {
        path: 'profile/edit',
        component: UserInfoEditorComponent,
    },
    {
        path: 'profile/:nickname',
        component: UserProfileComponent,
    },
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule],
})
export class UserRoutingModule {}
