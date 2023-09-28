import { Component, Input, OnInit } from '@angular/core';
import { AuthService } from '@core/services/auth.service';
import { ChallengeService } from '@core/services/challenge.service';
import { AssetConstants } from '@shared/constants/asset-constants';
import { IChallengePreview } from '@shared/models/challenge/challenge-preview';
import { IStar } from '@shared/models/challenge-star/star';
import { IUser } from '@shared/models/user/user';
import { getLanguageIconUrl } from '@shared/utils/language-icons';

@Component({
    selector: 'app-challenge',
    templateUrl: './challenge.component.html',
    styleUrls: ['./challenge.component.sass'],
})
export class ChallengeComponent implements OnInit {
    constructor(private challengeService: ChallengeService, private authService: AuthService) {}

    @Input() challenge: IChallengePreview;

    challengePositiveFeedbacksPercent = 0;

    isChallengeUpdated = true;

    getLanguageIconUrl = getLanguageIconUrl;

    canEdit: boolean;

    AssetConstants = AssetConstants;

    private user: IUser;

    ngOnInit(): void {
        this.authService.getUser().subscribe((user) => {
            this.user = user;
            this.canEdit = this.challenge.createdBy === this.user.id;
        });
    }

    starChange() {
        this.isChallengeUpdated = false;

        const star: IStar = {
            authorId: this.user.id,
            challenge: this.challenge,
            isStar: this.challenge.isStarry,
        };

        this.challengeService.updateStar(star).subscribe((challenge: IChallengePreview) => {
            this.challenge = challenge;
            this.isChallengeUpdated = true;
        });
    }
}
