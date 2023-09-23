import { Component, Input, OnInit } from '@angular/core';
import { LevelColorMapper } from '@modules/user/user-profile/user-profile.utils';
import { LanguageLevel } from '@shared/enums/language-level';

@Component({
    selector: 'app-progress-bar',
    templateUrl: './progress-bar.component.html',
    styleUrls: ['./progress-bar.component.sass'],
})
export class ProgressBarComponent implements OnInit {
    @Input() total: number;

    @Input() solved: number;

    @Input() data: string;

    @Input() level: LanguageLevel;

    public progressBarColor: string;

    public backgroundBarColor: string;

    public labelName: string;

    public ngOnInit(): void {
        this.labelName = LanguageLevel[this.level];
        this.progressBarColor = LevelColorMapper[this.level].activeColor;
        this.backgroundBarColor = LevelColorMapper[this.level].inactiveColor;
    }
}
