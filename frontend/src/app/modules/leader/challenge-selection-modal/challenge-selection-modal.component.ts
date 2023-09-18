import { Component, Input, OnInit } from '@angular/core';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';
import { IFightChallengeSettings } from '@shared/models/challenge/fight-challenge';
import { IChallengeLevel } from '@shared/models/challenge-level/challenge-level';
import { ILanguage } from '@shared/models/language/language';

@Component({
    selector: 'app-challenge-selection-modal',
    templateUrl: './challenge-selection-modal.component.html',
    styleUrls: ['./challenge-selection-modal.component.sass'],
})
export class ChallengeSelectionModalComponent implements OnInit {
    @Input() languages: ILanguage[];

    @Input() levels: IChallengeLevel[];

    public languagesNames: string[];

    public levelsNames: string[];

    private fightChallengeSettings: IFightChallengeSettings = {
        languageId: 0,
        levelId: 0,
    };

    constructor(public activeModal: NgbActiveModal) {}

    public ngOnInit(): void {
        this.languagesNames = this.languages.map((item) => item.name);
        this.levelsNames = this.levels.map((item) => item.name);
    }

    public confirmCodeFightRequest() {
        //TODO: backend

        this.activeModal.close();
    }

    public onLanguageChanged(value: string | string[]) {
        if (typeof value !== 'string') {
            return;
        }

        this.fightChallengeSettings.languageId = this.languages.find((language) => language.name === value)?.id ?? 0;
    }

    public onLevelChanged(value: string | string[]) {
        if (typeof value !== 'string') {
            return;
        }

        this.fightChallengeSettings.levelId = this.levels.find((level) => level.name === value)?.id ?? 0;
    }
}
