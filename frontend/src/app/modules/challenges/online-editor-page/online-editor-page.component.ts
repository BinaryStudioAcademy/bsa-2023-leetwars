import { BreakpointObserver } from '@angular/cdk/layout';
import { Component, ElementRef, OnDestroy, OnInit, ViewChild } from '@angular/core';
import { ActivatedRoute, ParamMap, Router } from '@angular/router';
import { BaseComponent } from '@core/base/base.component';
import { CodeDisplayingHubService } from '@core/hubs/code-displaying-hub.service';
import { AuthService } from '@core/services/auth.service';
import { ChallengeService } from '@core/services/challenge.service';
import { CodeRunService } from '@core/services/code-run.service';
import { ToastrNotificationsService } from '@core/services/toastr-notifications.service';
import { languageNameMap } from '@shared/mappings/language-map';
import { IChallenge } from '@shared/models/challenge/challenge';
import { IChallengeVersion } from '@shared/models/challenge-version/challenge-version';
import { ICodeRunRequest } from '@shared/models/code-run/code-run-request';
import { ICodeRunResults } from '@shared/models/code-run/code-run-result';
import { ICodeFightEnd } from '@shared/models/codefight/code-fight-end';
import { EditorOptions } from '@shared/models/options/editor-options';
import { IUser } from '@shared/models/user/user';
import { takeUntil } from 'rxjs';

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

    public isCodeFight: boolean;

    private isFullscreen = false;

    constructor(
        private activatedRoute: ActivatedRoute,
        private challengeService: ChallengeService,
        private breakpointObserver: BreakpointObserver,
        private signalRService: CodeDisplayingHubService,
        private toastrService: ToastrNotificationsService,
        private codeRunService: CodeRunService,
        private authService: AuthService,
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

        this.authService.getUser().subscribe((user: IUser) => {
            this.user = user;
        });

        this.isCodeFight = this.router.url.includes('codefight');

        this.subscribeToMessageQueue();
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

    sendCode(): void {
        this.solution = {
            userConnectionId: this.user.id.toString(),
            language: this.selectedLanguage,
            userCode: this.initialSolution as string,
            tests: this.testCode,
        };
        this.challengeService.runTests(this.solution).subscribe();
    }

    submitSolution(): void {
        this.sendCode();
    }

    subscribeToMessageQueue(): void {
        this.signalRService.start();
        this.signalRService.listenMessages((msg: ICodeRunResults) => {
            this.codeRunService.getCodeRunResults(msg);
        });
    }

    public giveUpCodeFight() {
        const codeFightEnd: ICodeFightEnd = {
            senderId: this.user.id,
        };

        this.challengeService.sendCodeFightEnd(codeFightEnd).subscribe();
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
