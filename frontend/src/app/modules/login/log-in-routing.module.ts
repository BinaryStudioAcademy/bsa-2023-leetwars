import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { LogInPageComponent } from './log-in-page/log-in-page.component';
import { SignUpComponent } from './sign-up-page/sign-up.component';

const routes: Routes = [
    { path: 'login', component: LogInPageComponent },
    { path: 'register', component: SignUpComponent },
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule],
})
export class LogInRoutingModule {}
