import { NgModule } from '@angular/core';
import { SharedModule } from '@shared/shared.module';

import { LogInPageComponent } from './log-in-page/log-in-page.component';
import { LogInRoutingModule } from './log-in-routing.module';

@NgModule({
    declarations: [LogInPageComponent],
    imports: [SharedModule, LogInRoutingModule],
})
export class LogInModule {}