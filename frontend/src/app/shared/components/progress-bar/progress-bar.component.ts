import { Component, Input, OnInit } from '@angular/core';
import { LevelColorMapper } from '@modules/user/user-profile/user-profile.utils';
import { LanguageLevel } from '@shared/enums/languageLevel';

@Component({
    selector: 'app-progress-bar',
    templateUrl: './progress-bar.component.html',
    styleUrls: ['./progress-bar.component.sass'],
})
export class ProgressBarComponent implements OnInit {
    @Input() total: number;

    @Input() solved: number;

    @Input() data: string;

    @Input() level: LanguageLevel = LanguageLevel.FirstSteps;

    progressBarColor: string;
    backgroundBarColor: string;

    ngOnInit(): void {
        this.progressBarColor = LevelColorMapper[this.level].activeColor;
        this.backgroundBarColor = LevelColorMapper[this.level].inactiveColor;
    }

    getDarkerColor = () => `darken(${this.progressBarColor}, 50%)`;
}
