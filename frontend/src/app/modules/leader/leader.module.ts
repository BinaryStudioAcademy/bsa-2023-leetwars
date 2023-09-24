import { NgModule } from '@angular/core';
import { SharedModule } from '@shared/shared.module';

import { LeaderBoardComponent } from './leader-board/leader-board.component';
import { LeaderRoutingModule } from './leader-routing.module';
import { ChallengeSelectionModalComponent } from './challenge-selection-modal/challenge-selection-modal.component';

@NgModule({
    declarations: [LeaderBoardComponent, ChallengeSelectionModalComponent],
    imports: [SharedModule, LeaderRoutingModule],
})
export class LeaderModule {}
