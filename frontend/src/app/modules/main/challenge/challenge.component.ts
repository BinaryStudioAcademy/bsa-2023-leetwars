import { Component, Input } from '@angular/core';
import { ChallengePreview } from '@shared/models/challenge/challenge-preview';
import { getLanguageIconUrl } from '@shared/utils/language-icons';

@Component({
    selector: 'app-challenge',
    templateUrl: './challenge.component.html',
    styleUrls: ['./challenge.component.sass'],
})
export class ChallengeComponent {
    @Input() challenge: ChallengePreview;

    public challengeStars = 0;

    public challengePositiveFeedbacksPercent = 0;

    public getLanguageIconUrl = getLanguageIconUrl;
}
