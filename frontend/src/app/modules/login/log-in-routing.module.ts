import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { ChangePasswordComponent } from './change-password/change-password.component';
import { ForgetPasswordComponent } from './forget-password/forget-password.component';
import { LogInPageComponent } from './log-in-page/log-in-page.component';
import { SignUpComponent } from './sign-up-page/sign-up.component';

const routes: Routes = [
    { path: 'login', component: LogInPageComponent },
    { path: 'register', component: SignUpComponent },
    { path: 'forget-password', component: ForgetPasswordComponent },
    { path: 'action', component: ChangePasswordComponent },
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule],
})
export class LogInRoutingModule {}
