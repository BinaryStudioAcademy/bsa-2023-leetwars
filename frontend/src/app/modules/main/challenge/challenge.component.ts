import { Component, Input } from '@angular/core';
import { AuthService } from '@core/services/auth.service';
import { StarService } from '@core/services/star.service';
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
    constructor(private starService: StarService, private authService: AuthService) {
        this.authService.getUser().subscribe((user) => {
            this.user = user;
        });
    }

    @Input() challenge: ChallengePreview;

    public challengePositiveFeedbacksPercent = 0;

    public getLanguageIconUrl = getLanguageIconUrl;

    private user: User;

    public starChange() {
        const star: Star = {
            authorId: this.user.id,
            challenge: this.challenge,
            isStar: !this.challenge.isStarry,
        };

        this.starService.updateStar(star).subscribe((starResp: Star) => {
            this.challenge.isStarry = starResp.isStar;
            this.challenge.starsAmount = starResp.isStar
                ? this.challenge.starsAmount + 1
                : this.challenge.starsAmount - 1;
        });
    }
}
