import { Component, Input, OnInit } from '@angular/core';
import { AuthService } from '@core/services/auth.service';
import { ChallengeService } from '@core/services/challenge.service';
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
    constructor(private challengeService: ChallengeService, private authService: AuthService) {
        this.authService.getUser().subscribe((user) => {
            this.user = user;
        });
    }

    @Input() challenge: IChallengePreview;

    public challengePositiveFeedbacksPercent = 0;

    public isChallengeUpdated = true;

    public getLanguageIconUrl = getLanguageIconUrl;

    public canEdit: boolean;

    private user: IUser;

    ngOnInit(): void {
        this.canEdit = this.challenge.createdBy == this.user.id;
    }

    public starChange() {
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
