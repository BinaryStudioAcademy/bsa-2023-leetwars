import { BreakpointObserver } from '@angular/cdk/layout';
import { Component, ElementRef, OnDestroy, OnInit, ViewChild } from '@angular/core';
import { ActivatedRoute, ParamMap } from '@angular/router';
import { BaseComponent } from '@core/base/base.component';
import { CodeDisplayingHubService } from '@core/hubs/code-displaying-hub.service';
import { ChallengeService } from '@core/services/challenge.service';
import { ToastrNotificationsService } from '@core/services/toastr-notifications.service';
import { languageNameMap } from '@shared/mappings/language-map';
import { IChallenge } from '@shared/models/challenge/challenge';
import { IChallengeVersion } from '@shared/models/challenge-version/challenge-version';
import { ICodeRunRequest } from '@shared/models/code-run/code-run-request';
import { ICodeRunResults } from '@shared/models/code-run/code-run-result';
import { EditorOptions } from '@shared/models/options/editor-options';
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
    private isFullscreen = false;

    constructor(
        private activatedRoute: ActivatedRoute,
        private challengeService: ChallengeService,
        private breakpointObserver: BreakpointObserver,
        private signalRService: CodeDisplayingHubService,
        private toastrNotification: ToastrNotificationsService,
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

    toggleFullScreen() {
        const element = this.editorContainer.nativeElement;

        if (!this.isFullscreen) {
            element.requestFullscreen();
            this.isFullscreen = true;
        } else {
            document.exitFullscreen();
            this.isFullscreen = false;
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

    onSelectedLanguageChanged($event: string | string[]): void {
        const selectedLang = this.mapLanguageName($event as string);

        this.initialSolution = this.getInitialSolutionByLanguage($event as string)!;

        this.languageVersions = this.getLanguageVersionsByLanguage(selectedLang);
        [this.selectedLanguageVersion] = this.languageVersions;
    }

    onCodeChanged(newCode: string) {
        this.initialSolution = newCode;
    }

    selectTab(title: string): void {
        this.activeTab = title;
    }

    isSelected(title: string): boolean {
        return this.activeTab === title;
    }

    sendCode(): void {
        this.solution = {
            userConnectionId: this.signalRService.connectionId,
            challengeVersionId: this.challenge.id,
            language: this.selectedLanguage,
            userCode: this.initialSolution as string,
        };

        this.challengeService.postCode(this.solution).subscribe();
    }

    subscribeToMessageQueue(): void {
        this.signalRService.start();
        this.signalRService.listenMessages((msg: string) => {
            const codeRunResults: ICodeRunResults = JSON.parse(msg) as ICodeRunResults;

            if (codeRunResults.buildResults?.isSuccess) {
                this.toastrNotification.showSuccess('code was compiled successfully');
            } else {
                this.toastrNotification.showError(codeRunResults.buildResults?.buildMessage as string);
            }
        });
    }

    private loadChallenge(challengeId: number) {
        this.challengeService.getChallengeById(challengeId).subscribe(
            (challenge) => {
                this.setupLanguages(challenge);
                this.setupEditorOptions();
            },
        );
    }

    private setupLanguages(challenge: IChallenge) {
        this.challenge = challenge;
        this.languages = challenge.versions.map((v) => v.language.name);
        this.languageVersions = this.extractLanguageVersions(challenge.versions);
        [this.selectedLanguage] = this.languages;
        [this.selectedLanguageVersion] = this.languageVersions;
    }

    private extractLanguageVersions(versions: IChallengeVersion[]) {
        return versions.flatMap((version) =>
            version.language.languageVersions.map((languageVersion) => languageVersion.version));
    }

    private setupEditorOptions() {
        this.initialSolution = this.getInitialSolutionByLanguage(this.selectedLanguage);
        this.testCode = this.getInitialTestByChallengeVersionId(this.challenge.versions[0].id);
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

    private getInitialSolutionByLanguage(language: string): string | undefined {
        const version = this.challenge.versions.find((v) => v.language.name === language);

        return version?.initialSolution;
    }

    private getInitialTestByChallengeVersionId(id: number) {
        const selectedVersion = this.challenge.versions.find((version) => version.id === id);

        return (selectedVersion && selectedVersion.tests?.length)
            ? selectedVersion.tests[0].code
            : 'No tests available';
    }

    private mapLanguageName(language: string): string {
        return languageNameMap.get(language) || language.toLowerCase();
    }

    private getLanguageVersionsByLanguage(language: string) {
        return this.challenge.versions
            .filter((version) => this.mapLanguageName(version.language.name) === language)
            .flatMap((version) => version.language.languageVersions
                .map((languageVersion) => languageVersion.version));
    }

    override ngOnDestroy() {
        this.signalRService.stop();
        super.ngOnDestroy();
    }
}
