import { Component, OnInit } from '@angular/core';
import { BaseComponent } from '@core/base/base.component';
import { ChallengeService } from '@core/services/challenge.service';
import { LanguageService } from '@core/services/language.service';
import { ToastrNotificationsService } from '@core/services/toastr-notifications.service';
import {
    getDropdownItems,
    getNewChallenge,
    getNewChallengeVersion, getStep, getStepChecking, getStepIndex,
    stepAllowed,
    steps,
} from '@modules/challenges/challenge-creation/challenge-creation.utils';
import { CategoryType } from '@shared/enums/category-type';
import { ChallengeStep } from '@shared/enums/challenge-step';
import { NewChallenge } from '@shared/models/challenge/new-challenge';
import { NewChallengeVersion } from '@shared/models/challenge-version/new-challenge-version';
import { DropdownItem } from '@shared/models/dropdown-item';
import { Language } from '@shared/models/language/language';
import { getEditorLanguageName } from '@shared/utils/editor-languages';
import { select } from 'd3-selection';
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
        private languageService: LanguageService,
        private toastrService: ToastrNotificationsService,
    ) {
        super();
        this.stepNames = this.steps.map(s => s.step.toString());
        this.challenge = getNewChallenge();
        this.challengeVersion = getNewChallengeVersion();
    }

    ngOnInit(): void {
        this.getLanguages();
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
            console.log('hello');
        }
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
                    [this.currentLanguage] = this.languageDropdownItems;
                    this.challenge.versions = data.map(l => {
                        const version = getNewChallengeVersion();

                        version.languageId = l.id;

                        return version;
                    });
                },
                error: () => {
                    this.toastrService.showError('Server connection error');
                },
            });
    }
}