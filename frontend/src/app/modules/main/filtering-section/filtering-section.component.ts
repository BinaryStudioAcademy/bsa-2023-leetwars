import { Component, OnInit } from '@angular/core';
import { BaseComponent } from '@core/base/base.component';
import { ChallengeService } from '@core/services/challenge.service';
import { LanguageService } from '@core/services/language.service';
import { PreferencesService } from '@core/services/preferences.service';
import { TagService } from '@core/services/tag.service';
import { ToastrNotificationsService } from '@core/services/toastr-notifications.service';
import {
    PROGRESS_NAMES_MAP,
    SORTING_PROPERTIES,
    STATUS_NAMES_MAP,
} from '@modules/main/filtering-section/filtering-section.utils';
import { LanguageLevel } from '@shared/enums/language-level';
import { IChallengeFilter } from '@shared/models/challenge/challenge-filter';
import { IChallengePreview } from '@shared/models/challenge/challenge-preview';
import { ISortedModel } from '@shared/models/challenge/sorted-model';
import { ILanguage } from '@shared/models/language/language';
import { IPageSettings } from '@shared/models/page-settings';
import { ITag } from '@shared/models/tag/tag';
import { Subject, takeUntil } from 'rxjs';

@Component({
    selector: 'app-filtering-section',
    templateUrl: './filtering-section.component.html',
    styleUrls: ['./filtering-section.component.sass'],
})
export class FilteringSectionComponent extends BaseComponent implements OnInit {
    challenges: IChallengePreview[] = [];

    loading = false;

    languagesNames: string[] = [];

    statusesNames: string[] = [];

    progressesNames: string[] = [];

    tagsNames: string[] = [];

    sortingLabels = SORTING_PROPERTIES.map((x) => x.label) as string[];

    difficultyNames: string[];

    preferenceLanguage: string;

    public scrollEventSubject = new Subject<void>();

    private sortingProperty?: ISortedModel;

    private page: IPageSettings = {
        pageNumber: 0,
        pageSize: 10,
    };

    private isLastPage = false;

    private filter: IChallengeFilter = {
        title: '',
        tagsIds: [],
    };

    private progresses = PROGRESS_NAMES_MAP;

    private tags: ITag[] = [];

    private languages: ILanguage[] = [];

    private statuses = STATUS_NAMES_MAP;

    constructor(
        private challengeService: ChallengeService,
        private languageService: LanguageService,
        private tagService: TagService,
        private toastrService: ToastrNotificationsService,
        private preferencesService: PreferencesService,
    ) {
        super();
    }

    ngOnInit(): void {
        this.getPreferences();
        this.getLanguages();
        this.getTags();

        this.statusesNames = this.statuses.map((item) => item.name);
        this.progressesNames = this.progresses.map((item) => item.name);
        this.difficultyNames = Object.values(LanguageLevel);
    }

    onScroll() {
        if (this.isLastPage) {
            return;
        }

        this.getChalenges();
    }

    onSearchTextChange(value: string) {
        this.filter.title = value.trim();
        this.resetChallengesData();
    }

    onSortChange(value: string | string[]) {
        if (typeof value !== 'string') {
            return;
        }
        this.sortingProperty = SORTING_PROPERTIES.find((x) => x.label === value);

        this.resetChallengesData();
    }

    onLanguageChange(value: string | string[]) {
        if (typeof value !== 'string') {
            return;
        }

        this.filter.languageId = this.languages.find((item) => item.name === value)?.id;
        this.resetChallengesData();
    }

    onStatusChange(value: string | string[]) {
        if (typeof value !== 'string') {
            return;
        }

        this.filter.challengeStatus = this.statuses.find((item) => item.name === value)?.status;
        this.resetChallengesData();
    }

    onProgressChange(value: string | string[]) {
        if (typeof value !== 'string') {
            return;
        }

        this.filter.progress = this.progresses.find((item) => item.name === value)?.state;
        this.resetChallengesData();
    }

    onTagsChange(value: string | string[]) {
        if (typeof value === 'string') {
            return;
        }

        this.filter.tagsIds = value
            .map((tagName) => this.tags.find((item) => item.name === tagName)?.id ?? 0)
            .filter((item) => item !== 0);

        this.resetChallengesData();
    }

    onDifficultyChange(value: string | string[]) {
        if (typeof value !== 'string') {
            return;
        }

        this.filter.skillLevel = LanguageLevel[value as keyof typeof LanguageLevel];
        this.resetChallengesData();
    }

    private getPreferences() {
        this.preferencesService.getUserPrefferences().subscribe((preferences) => {
            this.preferenceLanguage = preferences?.language.name ? preferences?.language.name : '';
            this.filter.languageId = preferences?.language?.id;
            this.getChalenges();
        });
    }

    private getChalenges() {
        if (this.isLastPage) {
            return;
        }

        this.page.pageNumber++;
        this.loading = true;

        this.challengeService
            .getChallenges(this.filter, this.page, this.sortingProperty)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe({
                next: (data) => {
                    this.loading = false;
                    if (!data.length) {
                        this.isLastPage = true;

                        return;
                    }
                    this.challenges = [...this.challenges, ...data];
                },
                error: () => {
                    this.loading = false;
                    this.toastrService.showError('Server connection error');
                },
            });
    }

    private getTags() {
        this.tagService
            .getTags()
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe({
                next: (data) => {
                    this.tags = data;
                    this.tagsNames = ['All', ...data.map((tag) => tag.name)];
                },
                error: () => {
                    this.toastrService.showError('Server connection error');
                },
            });
    }

    private getLanguages() {
        this.languageService
            .getLanguages()
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe({
                next: (data) => {
                    this.languages = data;
                    this.languagesNames = ['All', ...data.map((language) => language.name)];
                },
                error: () => {
                    this.toastrService.showError('Server connection error');
                },
            });
    }

    private resetChallengesData() {
        this.challenges = [];
        this.page.pageNumber = 0;
        this.isLastPage = false;
        this.getChalenges();
    }
}
