import { NgModule } from '@angular/core';
import { SharedModule } from '@shared/shared.module';

import { LeaderBoardComponent } from './leader-board/leader-board.component';
import { LeaderRoutingModule } from './leader-routing.module';

@NgModule({
    declarations: [LeaderBoardComponent],
    imports: [SharedModule, LeaderRoutingModule],
})
export class LeaderModule {}
