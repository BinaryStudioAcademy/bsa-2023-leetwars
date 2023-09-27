import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { BaseComponent } from '@core/base/base.component';
import { ChallengeService } from '@core/services/challenge.service';
import { LanguageService } from '@core/services/language.service';
import { TagService } from '@core/services/tag.service';
import { ToastrNotificationsService } from '@core/services/toastr-notifications.service';
import {
    editorOptions,
    getDropdownItems,
    getNewChallenge,
    getNewChallengeVersion,
    mapLanguageName,
} from '@modules/challenges/challenge-creation/challenge-creation.utils';
import { CategoryType } from '@shared/enums/category-type';
import { IEditChallenge } from '@shared/models/challenge/edit-challenge';
import { INewChallenge } from '@shared/models/challenge/new-challenge';
import { IChallengeGenerateRequest } from '@shared/models/challenge-generate/challenge-generate-request';
import { IChallengeLevel } from '@shared/models/challenge-level/challenge-level';
import { INewChallengeVersion } from '@shared/models/challenge-version/new-challenge-version';
import { IDropdownItem } from '@shared/models/dropdown-item';
import { ILanguage } from '@shared/models/language/language';
import { IModalButton } from '@shared/models/modal-button';
import { ITag } from '@shared/models/tag/tag';
import { takeUntil } from 'rxjs';

@Component({
    selector: 'app-describe-question',
    templateUrl: './describe-question.component.html',
    styleUrls: ['./describe-question.component.sass'],
})
export class DescribeQuestionComponent extends BaseComponent implements OnInit {
    @Input() challenge: INewChallenge | IEditChallenge = getNewChallenge();

    @Input() allTags: ITag[];

    @Input() allLevels: IChallengeLevel[];

    public languages: ILanguage[];

    public languageDropdownItems: IDropdownItem[] = [];

    public currentLanguage?: IDropdownItem;

    public challengeVersion: INewChallengeVersion;

    public editorOptions = editorOptions;

    @Input() checkValidation = false;

    @Output() validationChange = new EventEmitter<boolean>();

    @Output() challengeGenerateRequestChange = new EventEmitter<IChallengeGenerateRequest>();

    public updateChallengeGenerateRequest() {
        const selectedLanguageName = this.currentLanguage?.content;
        const selectedLanguage: ILanguage | undefined = this.languages.find(
            (lang) => lang.name === selectedLanguageName,
        );
        const challengeGenerateRequest: IChallengeGenerateRequest = {
            title: this.challenge.title,
            category: this.challenge.category,
            level: this.challenge.level,
            tags: this.challenge.tags,
            language: selectedLanguage,
        };

        this.challengeGenerateRequestChange.emit(challengeGenerateRequest);
    }

    public allTagsNames: string[] = [];

    public selectedTagsNames: string[] = [];

    public allLevelsNames: string[] = [];

    public selectedLevelName = '';

    @Input() buttons: IModalButton[] = [];

    public customInputHeight = '48px';

    public customInputWidth = '100%';

    public CategoryType = CategoryType;

    constructor(
        private tagService: TagService,
        private challengeLevelService: ChallengeService,
        private toastrService: ToastrNotificationsService,
        private languageService: LanguageService,
    ) {
        super();
    }

    ngOnInit(): void {
        this.getTags();
        this.getChallengeLevels();
        this.getLanguages();
        this.updateChallengeGenerateRequest();
    }

    public onLanguageChanged(selectedItem: IDropdownItem) {
        this.currentLanguage = selectedItem;
        const language = this.languages.find((l) => l.name === selectedItem.content);

        if (!language) {
            return;
        }

        this.editorOptions.language = mapLanguageName(language.name);
        this.challengeVersion = this.challenge.versions.find((v) => v.languageId === language.id)!;
    }

    public onCategoryChange(value: CategoryType) {
        this.challenge.category = value;
    }

    public onLevelChange(value: string | string[]) {
        if (typeof value !== 'string') {
            return;
        }

        this.challenge.level = this.allLevels.find((item) => item.skillLevel === value);
        this.challenge.levelId = this.challenge.level?.id!;
    }

    public onTagsChange(value: string | string[]) {
        if (typeof value === 'string') {
            return;
        }

        this.challenge.tags = this.allTags.filter((tag) => value.includes(tag.name));
    }

    public onNameChange(value: string) {
        this.challenge.title = value;
    }

    private getTags() {
        this.tagService
            .getTags()
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe({
                next: (data) => {
                    this.allTags = data;
                    this.allTagsNames = this.allTags.map((tag) => tag.name);
                },
                error: () => {
                    this.toastrService.showError('Server connection error');
                },
            });
    }

    private getChallengeLevels() {
        this.challengeLevelService
            .getChallengeLevels()
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe({
                next: (data) => {
                    this.allLevels = data;
                    this.allLevelsNames = this.allLevels.map((level) => level.skillLevel);
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
                    this.handleLanguageData(data);
                },
                error: () => {
                    this.toastrService.showError('Server connection error');
                },
            });
    }

    private handleLanguageData(data: ILanguage[]) {
        this.languages = data;
        this.languageDropdownItems = getDropdownItems(data.map((item) => item.name));

        this.challenge.versions = data.map((lang) => ({
            ...getNewChallengeVersion(),
            languageId: lang.id,
        }));
        this.onLanguageChanged(this.languageDropdownItems[0]);
    }
}
