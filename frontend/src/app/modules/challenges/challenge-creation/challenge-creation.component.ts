import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { BaseComponent } from '@core/base/base.component';
import { ChallengeService } from '@core/services/challenge.service';
import { ChallengeLevelService } from '@core/services/challenge-level.service';
import { LanguageService } from '@core/services/language.service';
import { TagService } from '@core/services/tag.service';
import { ToastrNotificationsService } from '@core/services/toastr-notifications.service';
import {
    getDropdownItems,
    getNewChallenge,
    getNewChallengeVersion, getStep, getStepChecking, getStepIndex, prepareChallengeDto,
    stepAllowed,
    steps,
} from '@modules/challenges/challenge-creation/challenge-creation.utils';
import { CategoryType } from '@shared/enums/category-type';
import { ChallengeStep } from '@shared/enums/challenge-step';
import { NewChallenge } from '@shared/models/challenge/new-challenge';
import { ChallengeLevel } from '@shared/models/challenge-level/challenge-level';
import { NewChallengeVersion } from '@shared/models/challenge-version/new-challenge-version';
import { DropdownItem } from '@shared/models/dropdown-item';
import { Language } from '@shared/models/language/language';
import { Tag } from '@shared/models/tag/tag';
import { getEditorLanguageName } from '@shared/utils/editor-languages';
import { takeUntil } from 'rxjs';

@Component({
    selector: 'app-challenge-creation',
    templateUrl: './challenge-creation.component.html',
    styleUrls: ['./challenge-creation.component.sass'],
})
export class ChallengeCreationComponent extends BaseComponent implements OnInit {
    public stepNames: string[];

    public steps = steps;

    public currentStep = 0;

    public challenge: NewChallenge;

    public challengeVersion: NewChallengeVersion;

    public tags: Tag[] = [];

    public challengeLevels: ChallengeLevel[] = [];

    public languages: Language[] = [];

    public languageDropdownItems: DropdownItem[] = [];

    public currentLanguage?: DropdownItem;

    public editorLanguage = '';

    public languageVersionDropdownItems: DropdownItem[] = [];

    protected readonly getStepIndex = getStepIndex;

    protected readonly ChallengeStep = ChallengeStep;

    protected readonly getStepChecking = getStepChecking;

    constructor(
        private challengeService: ChallengeService,
        private challengeLevelService: ChallengeLevelService,
        private languageService: LanguageService,
        private tagService: TagService,
        private toastrService: ToastrNotificationsService,
        private router: Router,
    ) {
        super();
        this.stepNames = this.steps.map(s => s.step.toString());
        this.challenge = getNewChallenge();
        this.challengeVersion = getNewChallengeVersion();
    }

    ngOnInit(): void {
        this.getLanguages();
        this.getTags();
        this.getChallengeLevels();
    }

    onStepClick(stepIndex: number) {
        if (stepAllowed(stepIndex)) {
            this.currentStep = stepIndex;
        }
    }

    onNameChange(value: string) {
        this.challenge.title = value;
    }

    onDescriptionChange(value: string) {
        this.challenge.instructions = value;
    }

    onCategoryChange(value: CategoryType) {
        this.challenge.category = value;
    }

    onSelectedTagsChange(value: Tag[]) {
        this.challenge.tags = value;
    }

    onSelectedLevelChange(value?: ChallengeLevel) {
        this.challenge.level = value;
    }

    onValidationChange(stepType: ChallengeStep, isValid: boolean) {
        const step = getStep(stepType);

        if (step) {
            step.isValid = isValid;
        }
    }

    onCompleteSolutionChange(value: string) {
        this.challengeVersion.completeSolution = value;
    }

    onInitialSolutionChange(value: string) {
        this.challengeVersion.initialSolution = value;
    }

    onPreloadedCodeChange(value: string) {
        this.challengeVersion.preloadedCode = value;
    }

    onTestCasesChange(value: string) {
        this.challengeVersion.testCases = value;
    }

    onExampleTestCasesChangeChange(value: string) {
        this.challengeVersion.exampleTestCases = value;
    }

    onBtnCreateClick() {
        if (stepAllowed(this.steps.length)) {
            const newChallenge = prepareChallengeDto(this.challenge);

            this.challengeService.createChallenge(newChallenge)
                .pipe(takeUntil(this.unsubscribe$))
                .subscribe({
                    next: () => {
                        this.toastrService.showSuccess('Challenge was successful created');
                        this.router.navigate(['/']);
                    },
                    error: () => {
                        this.toastrService.showError('Server connection error');
                    },
                });
        }
    }

    onBtnCancelClick() {
        this.router.navigate(['/']);
    }

    onLanguageChanged(selectedItem: DropdownItem) {
        this.currentLanguage = selectedItem;
        const language = this.languages.find(l => l.name === selectedItem.content);

        if (!language) {
            return;
        }

        this.editorLanguage = getEditorLanguageName(language.name);
        this.challengeVersion = this.challenge.versions.find(v => v.languageId === language.id)!;
    }

    private getLanguages() {
        this.languageService.getLanguages()
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe({
                next: data => {
                    this.languages = data;
                    this.languageDropdownItems = getDropdownItems(data.map(item => item.name));
                    this.challenge.versions = data.map(l => {
                        const version = getNewChallengeVersion();

                        version.languageId = l.id;

                        return version;
                    });
                    this.onLanguageChanged(this.languageDropdownItems[0]);
                },
                error: () => {
                    this.toastrService.showError('Server connection error');
                },
            });
    }

    private getTags() {
        this.tagService.getTags()
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe({
                next: data => {
                    this.tags = data;
                },
                error: () => {
                    this.toastrService.showError('Server connection error');
                },
            });
    }

    private getChallengeLevels() {
        this.challengeLevelService.getLevels()
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe({
                next: data => {
                    this.challengeLevels = data;
                },
                error: () => {
                    this.toastrService.showError('Server connection error');
                },
            });
    }
}
