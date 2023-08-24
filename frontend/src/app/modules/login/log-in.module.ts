import { NgModule } from '@angular/core';
import { SharedModule } from '@shared/shared.module';

import { LogInPageComponent } from './log-in-page/log-in-page.component';
import { SignUpComponent } from './sign-up-page/sign-up.component';
import { LogInRoutingModule } from './log-in-routing.module';

@NgModule({
    declarations: [LogInPageComponent, SignUpComponent],
    imports: [SharedModule, LogInRoutingModule],
})
export class LogInModule {}
