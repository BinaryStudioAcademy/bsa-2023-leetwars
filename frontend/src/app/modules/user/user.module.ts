import { NgModule } from '@angular/core';
import { UserRoutingModule } from '@modules/user/user-routing.module';
import { SharedModule } from '@shared/shared.module';

@NgModule({
    declarations: [],
    imports: [SharedModule, UserRoutingModule],
})
export class UserModule { }
