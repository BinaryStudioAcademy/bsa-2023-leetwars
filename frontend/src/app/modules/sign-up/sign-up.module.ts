import { NgModule } from '@angular/core';
import { SharedModule } from '@shared/shared.module';

import { SignUpComponent } from './sign-up/sign-up.component';
import { SignUpRoutingModule } from './sign-up-routing.module';

@NgModule({
    declarations: [SignUpComponent],
    imports: [SharedModule, SignUpRoutingModule],
})
export class SingUpModule {}
