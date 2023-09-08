import { Component, Input } from '@angular/core';
import { AuthService } from '@core/services/auth.service';
import { ChallengeService } from '@core/services/challenge.service';
import { ChallengePreview } from '@shared/models/challenge/challenge-preview';
import { Star } from '@shared/models/challenge-star/star';
import { User } from '@shared/models/user/user';
import { getLanguageIconUrl } from '@shared/utils/language-icons';

@Component({
    selector: 'app-challenge',
    templateUrl: './challenge.component.html',
    styleUrls: ['./challenge.component.sass'],
})
export class ChallengeComponent {
    constructor(private challengeService: ChallengeService, private authService: AuthService) {
        this.authService.getUser().subscribe((user) => {
            this.user = user;
        });
    }

    @Input() challenge: ChallengePreview;

    public challengePositiveFeedbacksPercent = 0;

    public isChallengeUpdated = true;

    public getLanguageIconUrl = getLanguageIconUrl;

    private user: User;

    public starChange() {
        this.isChallengeUpdated = false;

        const star: Star = {
            authorId: this.user.id,
            challenge: this.challenge,
            isStar: this.challenge.isStarry,
        };

        this.challengeService.updateStar(star).subscribe((challenge: ChallengePreview) => {
            this.challenge = challenge;
            this.isChallengeUpdated = true;
        });
    }
}
