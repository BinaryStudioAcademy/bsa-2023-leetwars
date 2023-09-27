import { BreakpointObserver } from '@angular/cdk/layout';
import { Component, ElementRef, OnDestroy, OnInit, ViewChild } from '@angular/core';
import { ActivatedRoute, ParamMap, Router } from '@angular/router';
import { BaseComponent } from '@core/base/base.component';
import { CodeDisplayingHubService } from '@core/hubs/code-displaying-hub.service';
import { ChallengeService } from '@core/services/challenge.service';
import { ToastrNotificationsService } from '@core/services/toastr-notifications.service';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { SolutionSubmitModalComponent } from '@shared/components/solution-submit-modal/solution-submit-modal.component';
import { languageNameMap } from '@shared/mappings/language-map';
import { IChallenge } from '@shared/models/challenge/challenge';
import { IChallengeVersion } from '@shared/models/challenge-version/challenge-version';
import { ICodeRunRequest } from '@shared/models/code-run/code-run-request';
import { ICodeRunResults } from '@shared/models/code-run/code-run-result';
import { ICodeSubmitResult } from '@shared/models/code-run/code-submit-result';
import { EditorOptions } from '@shared/models/options/editor-options';
import { ITestsOutput } from '@shared/models/tests-output/tests-output';
import { IUser } from '@shared/models/user/user';
import { take, takeUntil } from 'rxjs';

@Component({
    selector: 'app-online-editor-page',
    templateUrl: './online-editor-page.component.html',
    styleUrls: ['./online-editor-page.component.sass'],
})
export class OnlineEditorPageComponent extends BaseComponent implements OnDestroy, OnInit {
    activeTab: string = 'Description';

    splitDirection: 'horizontal' | 'vertical';

    splitLeftMinSize: number = 20;

    splitRightMinSize: number = 20;

    challenge: IChallenge;

    selectedLanguage: string;

    selectedLanguageVersion: string;

    languages: string[];

    languageVersions: string[];

    initialSolution?: string;

    testCode?: string;

    editorOptions: EditorOptions;

    solution: ICodeRunRequest;

    user: IUser;

    userId: string;

    private isFullscreen = false;

    constructor(
        private activatedRoute: ActivatedRoute,
        private challengeService: ChallengeService,
        private breakpointObserver: BreakpointObserver,
        private signalRService: CodeDisplayingHubService,
        private toastrService: ToastrNotificationsService,
        private modalService: NgbModal,
        private router: Router,
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
        this.splitDirection = 'horizontal';
        this.activatedRoute.paramMap.subscribe((params: ParamMap) => {
            const challengeId = +params.get('id')!;

            this.loadChallenge(challengeId);
        });
        this.subscribeToMessageQueue();
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
        const selectedLang = this.mapLanguageName($event as string);

        this.selectedLanguage = selectedLang;

        this.initialSolution = this.getInitialSolutionByLanguage($event as string)!;

        this.languageVersions = this.getLanguageVersionsByLanguage(selectedLang);
        [this.selectedLanguageVersion] = this.languageVersions;
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

    subscribeToMessageQueue(): void {
        this.signalRService.start();
    }

    runSampleTests() {
        this.signalRService.codeRunResult$
            .pipe(take(1), takeUntil(this.unsubscribe$))
            .subscribe((codeRunResults: ICodeRunResults) => {
                if (codeRunResults.buildResults?.isSuccess && codeRunResults.testRunResults) {
                    this.toastrService.showSuccess('Code was compiled successfully');
                    this.showTestResults(codeRunResults.testRunResults);
                } else {
                    this.toastrService.showError(codeRunResults.buildResults?.buildMessage as string);
                }
            });

        this.sendCode();
    }

    sendSubmitRequest() {
        this.signalRService.codeSubmitResults$
            .pipe(take(1), takeUntil(this.unsubscribe$))
            .subscribe((codeSubmitResults: ICodeSubmitResult) => {
                const modalRef = this.modalService.open(SolutionSubmitModalComponent);

                modalRef.componentInstance.codeRunResults = codeSubmitResults.codeRunResult;
                modalRef.componentInstance.codeAnalysisResults = codeSubmitResults.codeAnalysisResult;
            });

        this.sendCode(true);
    }

    private sendCode(isSubmitRequest: boolean = false): void {
        this.solution = {
            userConnectionId: this.signalRService.singleUserGroupId,
            language: this.selectedLanguage,
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
        this.languageVersions = [...new Set(this.extractLanguageVersions(challenge.versions))];

        [this.selectedLanguage] = this.languages;
        [this.selectedLanguageVersion] = this.languageVersions;
    }

    private extractLanguageVersions(versions: IChallengeVersion[]) {
        return versions.flatMap((version) =>
            version.language.languageVersions.map((languageVersion) => languageVersion.version));
    }

    private setupEditorOptions() {
        this.initialSolution = this.getInitialSolutionByLanguage(this.selectedLanguage);
        this.testCode = this.getInitialTestByChallengeVersionId(this.challenge.versions[0]?.id);
        this.editorOptions = {
            theme: 'vs-dark',
            language: this.mapLanguageName(this.selectedLanguage),
            minimap: { enabled: false },
            automaticLayout: true,
            useShadows: false,
            wordWrap: 'on',
            lineNumbers: 'on',
        };
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

    private mapLanguageName(language?: string): string {
        return language ? languageNameMap.get(language) || language.toLowerCase() : 'No language available';
    }

    private getLanguageVersionsByLanguage(language: string) {
        return this.challenge.versions
            .filter((version) => this.mapLanguageName(version.language.name) === language)
            .flatMap((version) => version.language.languageVersions.map((languageVersion) => languageVersion.version));
    }

    override ngOnDestroy() {
        this.signalRService.stop();
        super.ngOnDestroy();
    }
}
