import { Component, Input } from '@angular/core';
import { IChallengePreview } from '@shared/models/challenge/challenge-preview';
import { AuthService } from '@core/services/auth.service';
import { ChallengeService } from '@core/services/challenge.service';
import { Star } from '@shared/models/challenge-star/star';
import { IUser } from '@shared/models/user/user';
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

    @Input() challenge: IChallengePreview;

    public challengePositiveFeedbacksPercent = 0;

    public getLanguageIconUrl = getLanguageIconUrl;

    private user: IUser;

    public starChange() {
        const star: Star = {
            authorId: this.user.id,
            challenge: this.challenge,
            isStar: !this.challenge.isStarry,
        };

        this.challengeService.updateStar(star).subscribe((challenge: IChallengePreview) => {
            this.challenge = challenge;
        });
    }
}
