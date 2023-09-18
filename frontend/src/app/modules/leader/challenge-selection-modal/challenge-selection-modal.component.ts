import { Component, Input, OnInit } from '@angular/core';
import {
    findItemIdByName,
    findSuggestionTypeByName,
    ICONS,
    SUGGESTION_TYPE_NAMES,
} from '@modules/main/suggested-challenge/suggested-challenge.utils';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';
import { SuggestionType } from '@shared/enums/suggestion-type';
import { ISuggestionSettings } from '@shared/models/challenge/suggestion-settings';
import { ILanguage } from '@shared/models/language/language';

@Component({
    selector: 'app-challenge-selection-modal',
    templateUrl: './challenge-selection-modal.component.html',
    styleUrls: ['./challenge-selection-modal.component.sass'],
})
export class ChallengeSelectionModalComponent implements OnInit {
    @Input() languages: ILanguage[];

    public languagesNames: string[];

    public suggestionTypesNames: string[];

    public suggestionIcons = ICONS;

    private suggestionTypes = SUGGESTION_TYPE_NAMES;

    private suggestionSettings: ISuggestionSettings = {
        languageId: 0,
        suggestionType: SuggestionType.Fundamentals,
    };

    constructor(public activeModal: NgbActiveModal) {}

    public ngOnInit(): void {
        this.languagesNames = this.languages.map((item) => item.name);
        this.suggestionTypesNames = this.suggestionTypes.map((item) => item.name);
    }

    public confirmCodeFightRequest() {
        //TODO: backend

        this.activeModal.close();
    }

    public onLanguageChanged(value: string | string[]) {
        if (typeof value !== 'string') {
            return;
        }
        this.suggestionSettings.languageId = findItemIdByName(this.languages, value);
    }

    public onSuggestionTypeChanged(value: string | string[]) {
        if (typeof value !== 'string') {
            return;
        }
        this.suggestionSettings.suggestionType = findSuggestionTypeByName(value);
    }
}
