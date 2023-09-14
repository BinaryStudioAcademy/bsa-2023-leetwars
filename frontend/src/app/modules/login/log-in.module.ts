import { NgModule } from '@angular/core';
import { SharedModule } from '@shared/shared.module';

import { ChangePasswordComponent } from './change-password/change-password.component';
import { ForgetPasswordComponent } from './forget-password/forget-password.component';
import { LogInPageComponent } from './log-in-page/log-in-page.component';
import { SignUpComponent } from './sign-up-page/sign-up.component';
import { LogInRoutingModule } from './log-in-routing.module';

@NgModule({
    declarations: [LogInPageComponent, SignUpComponent, ForgetPasswordComponent, ChangePasswordComponent],
    imports: [SharedModule, LogInRoutingModule],
})
export class LogInModule {}
