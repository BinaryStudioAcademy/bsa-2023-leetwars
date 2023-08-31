import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { OnlineEditorPageComponent } from './online-editor-page/online-editor-page.component';

const routes: Routes = [
    {
        path: '',
        component: OnlineEditorPageComponent,
    },
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule],
})
export class OnlineEditorRoutingModule {}
