import { BreakpointObserver } from '@angular/cdk/layout';
import { Component, ElementRef, OnDestroy, OnInit, ViewChild } from '@angular/core';
import { ActivatedRoute, ParamMap, Router } from '@angular/router';
import { BaseComponent } from '@core/base/base.component';
import { CodefightGuard } from '@core/guards/codefight.guard';
import { CodeDisplayingHubService } from '@core/hubs/code-displaying-hub.service';
import { AuthService } from '@core/services/auth.service';
import { ChallengeService } from '@core/services/challenge.service';
import { CodeFightService } from '@core/services/code-fight.service';
import { CodeRunService } from '@core/services/code-run.service';
import { SpinnerService } from '@core/services/spinner.service';
import { ToastrNotificationsService } from '@core/services/toastr-notifications.service';
import { UserService } from '@core/services/user.service';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { SolutionSubmitModalComponent } from '@shared/components/solution-submit-modal/solution-submit-modal.component';
import { IChallenge } from '@shared/models/challenge/challenge';
import { ICodeRunRequest } from '@shared/models/code-run/code-run-request';
import { ICodeRunResults } from '@shared/models/code-run/code-run-result';
import { ICodeSubmitResult } from '@shared/models/code-run/code-submit-result';
import { ICodeFightEnd } from '@shared/models/codefight/code-fight-end';
import { ITestsOutput } from '@shared/models/tests-output/tests-output';
import { INewUserSolution } from '@shared/models/user/new-user-solution';
import { IUser } from '@shared/models/user/user';
import { of, switchMap, take, takeUntil } from 'rxjs';

import { editorOptions, mapLanguageName } from '../challenge-creation/challenge-creation.utils';

@Component({
    selector: 'app-online-editor-page',
    templateUrl: './online-editor-page.component.html',
    styleUrls: ['./online-editor-page.component.sass'],
})
export class OnlineEditorPageComponent extends BaseComponent implements OnDestroy, OnInit {
    activeTab: string = 'Description';

    splitDirection: 'horizontal' | 'vertical';

    splitRightMinSize: number = 30;

    challenge: IChallenge;

    selectedLanguage: string;

    mappedSelectedLanguage: string;

    languages: string[];

    initialSolution?: string;

    testCode?: string;

    editorOptions = editorOptions;

    solution: ICodeRunRequest;

    user: IUser;

    userId: string;

    isCodeFight: boolean;

    private isFullscreen = false;

    constructor(
        private activatedRoute: ActivatedRoute,
        private challengeService: ChallengeService,
        private userService: UserService,
        private codeFightService: CodeFightService,
        private breakpointObserver: BreakpointObserver,
        private signalRService: CodeDisplayingHubService,
        private toastrService: ToastrNotificationsService,
        private modalService: NgbModal,
        private codeRunService: CodeRunService,
        private authService: AuthService,
        private codeFightGuard: CodefightGuard,
        private router: Router,
        private spinnerService: SpinnerService,
    ) {
        super();
        breakpointObserver
            .observe(['(max-width: 843px)'])
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe((result) => {
                this.splitDirection = result.matches ? 'vertical' : 'horizontal';
            });
    }

    @ViewChild('editorContainer') editorContainer: ElementRef;

    @ViewChild('editorTestContainer') editorTestContainer: ElementRef;

    toggleFullScreen(element: HTMLDivElement) {
        this.isFullscreen = !this.isFullscreen;
        if (this.isFullscreen) {
            element.requestFullscreen();
        } else {
            document.exitFullscreen();
        }
    }

    ngOnInit() {
        this.activatedRoute.paramMap.subscribe((params: ParamMap) => {
            const challengeId = +params.get('id')!;

            this.loadChallenge(challengeId);
        });

        this.authService.getUser().subscribe((user: IUser) => {
            this.user = user;
        });

        this.isCodeFight = this.router.url.includes('codefight');

        this.subscribeToMessageQueue();
    }

    override ngOnDestroy() {
        this.signalRService.stop();
        super.ngOnDestroy();
    }

    showTestResults(testResults: ITestsOutput) {
        if (testResults.isSuccess) {
            this.toastrService.showSuccess(`Tests were successful!\n Tests passed: ${testResults.passedCount}`);
        } else {
            this.toastrService.showError(`Tests failed \n Tests failed: ${testResults.failedCount}
            out of ${testResults.passedCount + testResults.failedCount}`);
        }
    }

    onSelectedLanguageChanged($event: string | string[]): void {
        const selectedLang = $event as string;

        this.selectedLanguage = selectedLang;
        this.mappedSelectedLanguage = mapLanguageName(selectedLang);

        this.initialSolution = this.getInitialSolutionByLanguage($event as string)!;

        this.testCode = this.getInitialTestsByLanguage($event as string);

        this.updateEditorOptionsLanguage();
    }

    onCodeChanged(newCode: string) {
        this.initialSolution = newCode;
    }

    onTestChanged(newTests: string) {
        this.testCode = newTests;
    }

    selectTab(title: string): void {
        this.activeTab = title;
    }

    isSelected(title: string): boolean {
        return this.activeTab === title;
    }

    giveUpCodeFight() {
        this.codeFightGuard
            .openModal()
            .closed.pipe(
                switchMap(() => {
                    const codeFightEnd: ICodeFightEnd = {
                        isWinner: false,
                        senderId: this.user.id,
                    };

                    return this.codeFightService.sendCodeFightEnd(codeFightEnd);
                }),
            )
            .subscribe(() => {
                this.router.navigate(['/']);
            });
    }

    subscribeToMessageQueue(): void {
        this.signalRService.start();
    }

    runSampleTests() {
        this.signalRService.codeRunResult$
            .pipe(take(1), takeUntil(this.unsubscribe$))
            .subscribe((codeRunResults: ICodeRunResults) => {
                this.codeRunService.getCodeRunResults(codeRunResults);
                this.spinnerService.hide();
            });

        this.spinnerService.show();
        this.sendCode();
    }

    sendSubmitRequest() {
        this.signalRService.codeSubmitResults$
            .pipe(take(1), takeUntil(this.unsubscribe$))
            .subscribe((codeSubmitResults: ICodeSubmitResult) => {
                this.openSubmitModal(codeSubmitResults);

                this.spinnerService.hide();
            });

        this.spinnerService.show();
        this.sendCode(true);
    }

    private openSubmitModal(codeSubmitResults: ICodeSubmitResult) {
        const modalRef = this.modalService.open(SolutionSubmitModalComponent);

        modalRef.componentInstance.codeRunResults = codeSubmitResults.codeRunResult;
        modalRef.componentInstance.codeAnalysisResults = codeSubmitResults.codeAnalysisResult;

        modalRef.closed.subscribe(() => {
            this.submitSolution(codeSubmitResults);
        });
    }

    private submitSolution(codeSubmitResults: ICodeSubmitResult) {
        if (codeSubmitResults.codeRunResult.buildResults?.isSuccess
            && codeSubmitResults.codeRunResult.testRunResults?.isSuccess
            && codeSubmitResults.codeRunResult.testRunResults.failedCount === 0) {
            const userSolution: INewUserSolution = {
                challengeVersionId: this.challenge.versions.find(v => v.language.name === this.selectedLanguage)?.id!,
                challengeId: this.challenge.id,
                code: this.initialSolution!,
                output: this.initialSolution!,
                createdBy: this.user.id,
            };

            this.userService.submitSolution(userSolution).pipe(
                switchMap(() => {
                    if (this.isCodeFight) {
                        const codeFightEnd: ICodeFightEnd = {
                            isWinner: true,
                            senderId: this.user.id,
                        };

                        return this.codeFightService.sendCodeFightEnd(codeFightEnd);
                    }

                    return of(undefined);
                }),
            ).subscribe(() => {
                this.router.navigate(['/user/profile'], { state: { canLeave: true } });
            });
        }
    }

    private sendCode(isSubmitRequest: boolean = false): void {
        this.solution = {
            userConnectionId: this.user.id.toString(),
            language: this.mappedSelectedLanguage,
            userCode: this.initialSolution as string,
            tests: this.testCode,
            isSubmitRequest,
        };
        this.challengeService.runTests(this.solution).subscribe();
    }

    private loadChallenge(challengeId: number) {
        this.challengeService
            .getChallengeById(challengeId)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe({
                next: (challenge) => {
                    this.setupLanguages(challenge);
                    this.setupEditorOptions();
                },
                error: () => {
                    this.toastrService.showError('Server connection error');
                    this.router.navigate(['/']);
                },
            });
    }

    private setupLanguages(challenge: IChallenge) {
        this.challenge = challenge;
        this.languages = [...new Set(challenge.versions?.map((v) => v.language?.name))];

        [this.selectedLanguage] = this.languages;
        this.mappedSelectedLanguage = mapLanguageName(this.selectedLanguage);
    }

    private setupEditorOptions() {
        this.initialSolution = this.getInitialSolutionByLanguage(this.selectedLanguage);
        this.testCode = this.getInitialTestByChallengeVersionId(this.challenge.versions[0]?.id);

        this.updateEditorOptionsLanguage();
    }

    private getInitialTestsByLanguage(language: string): string {
        const version = this.challenge.versions?.find((v) => v.language.name === language);

        return version?.exampleTestCases ?? 'No tests available';
    }

    private getInitialSolutionByLanguage(language: string): string {
        const version = this.challenge.versions?.find((v) => v.language.name === language);

        return version && version.initialSolution ? version.initialSolution : 'No solutions available';
    }

    private getInitialTestByChallengeVersionId(id: number) {
        const selectedVersion = this.challenge.versions.find((version) => version.id === id);

        return selectedVersion && selectedVersion.exampleTestCases
            ? selectedVersion.exampleTestCases
            : 'No tests available';
    }

    private updateEditorOptionsLanguage() {
        this.editorOptions.language = this.mappedSelectedLanguage.toLowerCase();
    }
}
