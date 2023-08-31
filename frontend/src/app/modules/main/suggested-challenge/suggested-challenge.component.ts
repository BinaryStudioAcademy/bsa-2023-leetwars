import { Component, OnInit } from '@angular/core';
import { BaseComponent } from '@core/base/base.component';
import { ChallengeService } from '@core/services/challenge.service';
import { LanguageService } from '@core/services/language.service';
import { ToastrNotificationsService } from '@core/services/toastr-notifications.service';
import { findItemIdByName, ICONS, SUGGESTION_TYPES } from '@modules/main/suggested-challenge/suggested-challenge.utils';
import { ChallengePreview } from '@shared/models/challenge/challenge-preview';
import { SuggestionSettings } from '@shared/models/challenge/suggestion-settings';
import { Language } from '@shared/models/language/language';
import { takeUntil } from 'rxjs';

@Component({
    selector: 'app-suggested-challenge',
    templateUrl: './suggested-challenge.component.html',
    styleUrls: ['./suggested-challenge.component.sass'],
})
export class SuggestedChallengeComponent extends BaseComponent implements OnInit {
    challenge?: ChallengePreview;

    languagesNames: string[] = [];

    languages: Language[] = [];

    suggestionTypesNames: string[];

    suggestionTypes = SUGGESTION_TYPES;

    suggestionIcons = ICONS;

    suggestionSettings: SuggestionSettings = {
        languageId: 0,
        suggestionType: 0,
    };

    constructor(
        private challengeService: ChallengeService,
        private languageService: LanguageService,
        private toastrService: ToastrNotificationsService,
    ) { super(); }

    public ngOnInit(): void {
        this.getLanguages();

        this.suggestionTypesNames = this.suggestionTypes.map(item => item.name);
    }

    public onLanguageChanged(value: string | string[]) {
        if (typeof value !== 'string') {
            return;
        }
        this.suggestionSettings.languageId = findItemIdByName(this.languages, value);
        this.getChallenge();
    }

    public onSuggestionTypeChanged(value: string | string[]) {
        if (typeof value !== 'string') {
            return;
        }
        this.suggestionSettings.suggestionType = findItemIdByName(this.suggestionTypes, value);
        this.getChallenge();
    }

    public onMouseWheel(event: WheelEvent): void {
        const container = document.querySelector('.tags');

        if (container) {
            container.scrollLeft += event.deltaY;
            event.preventDefault();
        }
    }

    public getChallenge() {
        this.challengeService.getChallengeSuggestion(this.suggestionSettings)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe({
                next: data => {
                    this.challenge = data;
                },
                error: () => {
                    this.toastrService.showError('Server connection error');
                },
            });
    }

    private getLanguages() {
        this.languageService.getLanguages()
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe({
                next: data => {
                    this.languages = data;
                    this.languagesNames = data.map(i => i.name);
                    this.suggestionSettings.languageId = data[0].id;
                    this.getChallenge();
                },
                error: () => {
                    this.toastrService.showError('Server connection error');
                },
            });
    }
}
