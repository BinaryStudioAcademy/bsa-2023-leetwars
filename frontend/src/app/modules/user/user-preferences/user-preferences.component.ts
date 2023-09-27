import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { BaseComponent } from '@core/base/base.component';
import { LanguageService } from '@core/services/language.service';
import { PreferencesService } from '@core/services/preferences.service';
import { ToastrNotificationsService } from '@core/services/toastr-notifications.service';
import { ILanguage } from '@shared/models/language/language';
import { IUser } from '@shared/models/user/user';
import { INewUserPreferences } from '@shared/models/user-prefferences/new-user-preferences';
import { IUserPreferences } from '@shared/models/user-prefferences/user-preferences';
import { fontSizeMaxValue, tabSizeMaxValue } from '@shared/utils/validation/form-control-validator-options';
import { getErrorMessage } from '@shared/utils/validation/validation-helper';
import { takeUntil } from 'rxjs';

import { findItemIdByName, MONACO_EDITOR_THEMES } from './user-preferences.utils';

@Component({
    selector: 'app-user-preferences',
    templateUrl: './user-preferences.component.html',
    styleUrls: ['./user-preferences.component.sass'],
})
export class UserPreferencesComponent extends BaseComponent implements OnInit {
    userPreferenceForm: FormGroup = new FormGroup({
        language: new FormControl(''),
        theme: new FormControl(''),
        tabSize: new FormControl(3, [Validators.max(tabSizeMaxValue), Validators.required]),
        fontSize: new FormControl(0, [Validators.max(fontSizeMaxValue)]),
        wordWrap: new FormControl(false),
    });

    user: IUser;

    languagesNames: string[] = [];

    isWordWrap: boolean;

    private languages: ILanguage[] = [];

    monacoThemes: string[] = MONACO_EDITOR_THEMES;

    constructor(
        private toastrService: ToastrNotificationsService,
        private languageService: LanguageService,
        private preferenceService: PreferencesService,
    ) { super(); }

    ngOnInit(): void {
        this.getLanguages();
        this.loadData();
    }

    setPreferences() {
        const language = findItemIdByName(this.languages, this.userPreferenceForm.value.language);

        const editorTheme = this.monacoThemes.includes(this.userPreferenceForm.value.theme)
            ? this.userPreferenceForm.value.theme
            : null;

        const newPreferences: INewUserPreferences = {
            languageId: language,
            theme: editorTheme,
            tabSize: this.userPreferenceForm.value.tabSize,
            fontSize: this.userPreferenceForm.value.fontSize,
            wordWrap: this.userPreferenceForm.value.wordWrap,
        };

        this.preferenceService
            .setUserPrefferences(newPreferences)
            .subscribe({
                next: () => {
                    this.toastrService.showSuccess('User preferences has been updated');
                },
                error: () => {
                    this.toastrService.showError('Something went wrong');
                },
            });
    }

    onLanguageChanged(value: string | string[]) {
        this.userPreferenceForm.value.language = value;
    }

    onThemeChanged(value: string | string[]) {
        if (typeof value !== 'string') {
            return;
        }
        this.userPreferenceForm.value.theme = value;
    }

    onCheckedChange(value: boolean) {
        console.log(value);
        this.isWordWrap = value;
    }

    getErrorMessage(formControlName: string) {
        return getErrorMessage(formControlName, this.userPreferenceForm);
    }

    private loadData() {
        this.preferenceService.getUserPrefferences().subscribe((preferences) => {
            this.initializeForm(preferences);
        });
    }

    private initializeForm(preferences: IUserPreferences) {
        this.userPreferenceForm.patchValue({
            tabSize: preferences?.tabSize,
            theme: preferences?.theme,
            fontSize: preferences?.fontSize,
            wordWrap: preferences?.wordWrap,
            language: preferences.language?.name,
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
                },
                error: () => {
                    this.toastrService.showError('Server connection error');
                },
            });
    }
}
