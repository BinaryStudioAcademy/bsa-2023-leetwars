import { Component, OnInit } from '@angular/core';
import { BaseComponent } from '@core/base/base.component';
import { ChallengeService } from '@core/services/challenge.service';
import { LanguageService } from '@core/services/language.service';
import { PreferencesService } from '@core/services/preferences.service';
import { ToastrNotificationsService } from '@core/services/toastr-notifications.service';
import {
    findItemIdByName,
    findSuggestionTypeByName,
    ICONS,
    SUGGESTION_TYPE_NAMES,
} from '@modules/main/suggested-challenge/suggested-challenge.utils';
import { SuggestionType } from '@shared/enums/suggestion-type';
import { IChallengePreview } from '@shared/models/challenge/challenge-preview';
import { ISuggestionSettings } from '@shared/models/challenge/suggestion-settings';
import { ILanguage } from '@shared/models/language/language';
import { takeUntil } from 'rxjs';

@Component({
    selector: 'app-suggested-challenge',
    templateUrl: './suggested-challenge.component.html',
    styleUrls: ['./suggested-challenge.component.sass'],
})
export class SuggestedChallengeComponent extends BaseComponent implements OnInit {
    suggestionType = SuggestionType;

    challenge?: IChallengePreview;

    languagesNames: string[] = [];

    suggestionTypesNames: string[];

    suggestionTypes = SUGGESTION_TYPE_NAMES;

    suggestionIcons = ICONS;

    preferenceLanguage: string;

    private languages: ILanguage[] = [];

    suggestionSettings: ISuggestionSettings = {
        suggestionType: SuggestionType.Fundamentals,
    };

    constructor(
        private challengeService: ChallengeService,
        private languageService: LanguageService,
        private toastrService: ToastrNotificationsService,
        private preferencesService: PreferencesService,
    ) {
        super();
    }

    ngOnInit(): void {
        this.getPreferences();
        this.getLanguages();

        this.suggestionTypesNames = this.suggestionTypes.map((item) => item.name);
    }

    onLanguageChanged(value: string | string[]) {
        if (typeof value !== 'string') {
            return;
        }
        this.suggestionSettings.languageId = findItemIdByName(this.languages, value);
        this.getChallenge();
    }

    onSuggestionTypeChanged(value: string | string[]) {
        if (typeof value !== 'string') {
            return;
        }
        this.suggestionSettings.suggestionType = findSuggestionTypeByName(value);
        this.getChallenge();
    }

    onMouseWheel(event: WheelEvent): void {
        const container = document.querySelector('.tags');

        if (container) {
            container.scrollLeft += event.deltaY;
            event.preventDefault();
        }
    }

    getChallenge() {
        this.challengeService
            .getChallengeSuggestion(this.suggestionSettings)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe({
                next: (data) => {
                    this.challenge = data;
                },
                error: () => {
                    this.toastrService.showError('Server connection error');
                },
            });
    }

    private getPreferences() {
        this.preferencesService.getUserPrefferences().subscribe((preferences) => {
            this.preferenceLanguage = preferences.language ? preferences.language.name : this.languagesNames[0];
            this.getChallenge();
        });
    }

    private getLanguages() {
        this.languageService
            .getLanguages()
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe({
                next: (data) => {
                    this.languages = data;
                    this.languagesNames = data.map((i) => i.name);
                    this.suggestionSettings.languageId = data[0].id;
                    this.getChallenge();
                },
                error: () => {
                    this.toastrService.showError('Server connection error');
                },
            });
    }
}
