import { Component, HostListener, OnInit } from '@angular/core';
import { ActivatedRoute, ParamMap, Router } from '@angular/router';
import { BaseComponent } from '@core/base/base.component';
import { ChallengeService } from '@core/services/challenge.service';
import { LanguageService } from '@core/services/language.service';
import { TagService } from '@core/services/tag.service';
import { ToastrNotificationsService } from '@core/services/toastr-notifications.service';
import {
    checkAllStepsIsValid,
    editorOptions,
    getDropdownItems,
    getInitStepsData,
    getNewChallenge,
    getNewChallengeVersion,
    getStepChecking,
    getStepData,
    mapLanguageName,
    prepareChallengeDto,
    showValidationErrorsForAllSteps,
    showValidationErrorsForRequiredSteps,
    stepIsAllowed,
} from '@modules/challenges/challenge-creation/challenge-creation.utils';
import { StepData } from '@modules/challenges/challenge-creation/step-data';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { ConfirmationModalComponent } from '@shared/components/confirmation-modal/confirmation-modal.component';
import { ChallengeStep } from '@shared/enums/challenge-step';
import { IEditChallenge } from '@shared/models/challenge/edit-challenge';
import { INewChallenge } from '@shared/models/challenge/new-challenge';
import { IChallengeLevel } from '@shared/models/challenge-level/challenge-level';
import { IEditChallengeVersion } from '@shared/models/challenge-version/edit-challenge-version';
import { INewChallengeVersion } from '@shared/models/challenge-version/new-challenge-version';
import { IDropdownItem } from '@shared/models/dropdown-item';
import { ILanguage } from '@shared/models/language/language';
import { ITag } from '@shared/models/tag/tag';
import { HasUnsavedChanges } from '@shared/models/unsaved-changes/has-unsaved-changes';
import { takeUntil } from 'rxjs';

@Component({
    selector: 'app-challenge-creation',
    templateUrl: './challenge-creation.component.html',
    styleUrls: ['./challenge-creation.component.sass'],
})
export class ChallengeCreationComponent extends BaseComponent implements HasUnsavedChanges, OnInit {
    steps: ChallengeStep[];

    stepsData: StepData[] = getInitStepsData();

    currentStep: ChallengeStep = ChallengeStep.Question;

    challengeId: number;

    challenge: INewChallenge | IEditChallenge;

    challengeVersion: INewChallengeVersion | IEditChallengeVersion;

    tags: ITag[] = [];

    challengeLevels: IChallengeLevel[] = [];

    languages: ILanguage[] = [];

    languageDropdownItems: IDropdownItem[] = [];

    currentLanguage?: IDropdownItem;

    editorOptions = editorOptions;

    unsavedChanges: boolean = true;

    protected readonly ChallengeStep = ChallengeStep;

    constructor(
        private challengeService: ChallengeService,
        private languageService: LanguageService,
        private tagService: TagService,
        private toastrService: ToastrNotificationsService,
        private router: Router,
        private activatedRoute: ActivatedRoute,
        private modalService: NgbModal,
    ) {
        super();
        this.steps = this.stepsData.map((s) => s.step);
        this.challenge = getNewChallenge();
        this.challengeVersion = getNewChallengeVersion();
    }

    @HostListener('window:beforeunload', ['$event'])
    reloadNotification($event: BeforeUnloadEvent): void {
        $event.returnValue = 'true';
    }

    ngOnInit(): void {
        this.activatedRoute.paramMap.subscribe((params: ParamMap) => {
            this.challengeId = +params.get('id')!;

            this.stepsData = getInitStepsData(!!this.challengeId);

            this.getTags();
            this.getChallengeLevels();
            this.getLanguages();

            if (this.challengeId) {
                this.loadChallenge(this.challengeId);
            }
        });
    }

    onStepClick(step: ChallengeStep) {
        this.stepsData = showValidationErrorsForRequiredSteps(this.stepsData, step);
        if (!stepIsAllowed(this.stepsData, step)) {
            return;
        }
        this.currentStep = step;
    }

    onValidationChange(step: ChallengeStep, isValid: boolean) {
        const stepData = getStepData(this.stepsData, step);

        if (stepData) {
            stepData.isValid = isValid;
        }
    }

    onBtnCreateClick() {
        this.stepsData = showValidationErrorsForAllSteps(this.stepsData);
        if (checkAllStepsIsValid(this.stepsData)) {
            const newChallenge = prepareChallengeDto(this.challenge);

            this.challengeService
                .createChallenge(newChallenge)
                .pipe(takeUntil(this.unsubscribe$))
                .subscribe({
                    next: () => {
                        this.unsavedChanges = false;
                        this.toastrService.showSuccess('Challenge was successfully created');
                        this.router.navigate(['/']);
                    },
                    error: (error) => {
                        this.toastrService.showError(error.title);
                    },
                });
        }
    }

    onBtnEditClick() {
        this.stepsData = showValidationErrorsForAllSteps(this.stepsData);
        if (checkAllStepsIsValid(this.stepsData)) {
            this.challengeService
                .updateChallenge(this.challenge as IEditChallenge)
                .pipe(takeUntil(this.unsubscribe$))
                .subscribe({
                    next: () => {
                        this.unsavedChanges = false;
                        this.toastrService.showSuccess('Challenge was successfully edited');
                        this.router.navigate(['/']);
                    },
                    error: (error) => {
                        this.toastrService.showError(error.title);
                    },
                });
        }
    }

    onBtnDeleteClick() {
        const modalRef = this.modalService.open(ConfirmationModalComponent, { windowClass: 'delete-modal' });

        modalRef.componentInstance.titleText = 'Do you really want to delete challenge?';
        modalRef.componentInstance.bodyText =
            'After confirmation, the challenge will be permanently deleted and cannot be recovered.';
        modalRef.componentInstance.buttons = [
            {
                text: 'Yes',
                handler: () => {
                    this.deleteChallenge();
                    modalRef.close();
                },
            },
            {
                text: 'Cancel',
                handler: () => {
                    modalRef.dismiss();
                },
            },
        ];
    }

    onBtnCancelClick() {
        this.router.navigate(['/']);
    }

    onLanguageChanged(selectedItem: IDropdownItem) {
        this.currentLanguage = selectedItem;
        const language = this.languages.find((l) => l.name === selectedItem.content);

        if (!language) {
            return;
        }

        this.editorOptions.language = mapLanguageName(language.name);
        this.challengeVersion = this.challenge.versions.find((v) => v.languageId === language.id)!;
    }

    getStepChecking(step: ChallengeStep) {
        return getStepChecking(this.stepsData, step);
    }

    private loadChallenge(challengeId: number) {
        this.challengeService
            .getChallengeById(challengeId)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe({
                next: (challenge) => {
                    this.challenge = { ...challenge };
                    [this.challengeVersion] = this.challenge.versions;
                    this.loadActualLanguages();
                },
                error: () => {
                    this.toastrService.showError('Server connection error');
                },
            });
    }

    private deleteChallenge() {
        this.challengeService
            .deleteChallenge(this.challengeId)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe({
                next: () => {
                    this.toastrService.showSuccess('Challenge was successfully deleted');
                    this.router.navigate(['/'], { state: { canLeave: true } });
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

    private loadActualLanguages() {
        const challengeVersionLanguages = this.languages.filter((lang) =>
            this.challenge.versions.some((version) => version.languageId === lang.id));

        this.languageDropdownItems = getDropdownItems(challengeVersionLanguages.map((lang) => lang.name));
        [this.currentLanguage] = this.languageDropdownItems;
    }

    private getTags() {
        this.tagService
            .getTags()
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe({
                next: (data) => {
                    this.tags = data;
                },
                error: () => {
                    this.toastrService.showError('Server connection error');
                },
            });
    }

    private getChallengeLevels() {
        this.challengeService
            .getChallengeLevels()
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe({
                next: (data) => {
                    this.challengeLevels = data;
                },
                error: () => {
                    this.toastrService.showError('Server connection error');
                },
            });
    }
}
