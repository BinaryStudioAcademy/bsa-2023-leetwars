import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { BaseComponent } from '@core/base/base.component';
import { LanguageService } from '@core/services/language.service';
import { ToastrNotificationsService } from '@core/services/toastr-notifications.service';
import { UserService } from '@core/services/user.service';
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
        tabSize: new FormControl(3, [Validators.max(tabSizeMaxValue)]),
        fontSize: new FormControl(15, [Validators.max(fontSizeMaxValue)]),
        wordWrap: new FormControl(false),
        minimap: new FormControl(false),
    });

    user: IUser;

    languagesNames: string[] = [];

    isWordWrap: boolean;

    private languages: ILanguage[] = [];

    private newPreferences: INewUserPreferences;

    monacoThemes: string[] = MONACO_EDITOR_THEMES;

    constructor(
        private toastrService: ToastrNotificationsService,
        private languageService: LanguageService,
        private userervice: UserService,
    ) { super(); }

    ngOnInit(): void {
        this.getLanguages();
        this.loadData();
    }

    setPreferences() {
        const language = findItemIdByName(this.languages, this.userPreferenceForm.value.language);

        const editorTheme = this.monacoThemes.find(item => item === this.userPreferenceForm.value.theme);

        this.newPreferences = {
            languageId: language,
            theme: editorTheme,
            tabSize: this.userPreferenceForm.value.tabSize,
            fontSize: this.userPreferenceForm.value.fontSize,
            isWordWrap: this.userPreferenceForm.value.wordWrap,
            isMinimap: this.userPreferenceForm.value.minimap,
        };
        this.updateUserPreferences();
    }

    private updateUserPreferences() {
        this.userervice
            .setUserPrefferences(this.newPreferences)
            .subscribe();
    }

    private loadData() {
        this.userervice.getUserPrefferences().subscribe((preferences) => {
            this.initializeForm(preferences);
        });
    }

    private initializeForm(preferences: IUserPreferences) {
        this.userPreferenceForm.patchValue({
            tabSize: preferences?.tabSize,
            theme: preferences?.theme,
            fontSize: preferences?.fontSize,
            wordWrap: preferences?.isWordWrap,
            language: preferences.language?.name,
            minimap: preferences?.isMinimap,
        });
    }

    onFontSizeChange(value: string) {
        this.userPreferenceForm.value.fontSize = value;
    }

    onTabSizeChange(value: string) {
        this.userPreferenceForm.value.tabSize = value;
    }

    onCheckedWrapChange() {
        this.userPreferenceForm.value.wordWrap = !this.userPreferenceForm.value.wordWrap;
    }

    onCheckedMinimapChange() {
        this.userPreferenceForm.value.minimap = !this.userPreferenceForm.value.minimap;
    }

    onLanguageChanged(value: string | string[]) {
        this.userPreferenceForm.value.language = value;
    }

    onThemeChanged(value: string | string[]) {
        this.userPreferenceForm.value.theme = value;
    }

    getErrorMessage(formControlName: string) {
        return getErrorMessage(formControlName, this.userPreferenceForm);
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
