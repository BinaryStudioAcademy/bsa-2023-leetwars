import { Component, Input } from '@angular/core';

@Component({
    selector: 'app-challenge',
    templateUrl: './challenge.component.html',
    styleUrls: ['./challenge.component.sass'],
})
export class ChallengeComponent {
    //TODO: Replace every variable started with 'challenge' to real challenge model with @Input decorator
    @Input() challenge = '';

    public challengeLevel = 3;

    public challengeTitle = 'Replace With Alphabet Position';

    public challengeStars = 540;

    public challengePositiveFeedbacksPercent = 88;

    public challengeAuthorName = 'Emerson Saris';

    public challengeLanguages = ['HTML, CSS, JS', 'Ruby', 'JS'];

    public challengeTags = ['Algorithms', 'Strings', 'Data Types', 'Formatting', 'Logic'];
}
