import { BreakpointObserver } from '@angular/cdk/layout';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, ParamMap } from '@angular/router';
import { BaseComponent } from '@core/base/base.component';
import { BroadcastHubService } from '@core/hubs/broadcast-hub.service';
import { ChallengeService } from '@core/services/challenge.service';
import { ToastrNotificationsService } from '@core/services/toastr-notifications.service';
import { languageNameMap } from '@shared/mappings/language-map';
import { IChallenge } from '@shared/models/challenge/challenge';
import { IChallengeVersion } from '@shared/models/challenge-version/challenge-version';
import { ICodeRunRequest } from '@shared/models/code-run-request/code-run-request';
import { ICodeRunResults } from '@shared/models/code-run-results/code-run-results';
import { EditorOptions } from '@shared/models/options/editor-options';
import { ITestsOutput } from '@shared/models/tests-output/tests-output';
import { takeUntil } from 'rxjs';

@Component({
    selector: 'app-online-editor-page',
    templateUrl: './online-editor-page.component.html',
    styleUrls: ['./online-editor-page.component.sass'],
})
export class OnlineEditorPageComponent extends BaseComponent implements OnInit {
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

    constructor(
        private activatedRoute: ActivatedRoute,
        private challengeService: ChallengeService,
        private breakpointObserver: BreakpointObserver,
        private signalRService: BroadcastHubService,
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

    ngOnInit() {
        this.signalRService.start();

        this.signalRService.listenMessages((message: string) => {
            const codeRunResults: ICodeRunResults = JSON.parse(message);

            if (codeRunResults.isBuilt && codeRunResults.testRunResults) {
                this.showTestResults(codeRunResults.testRunResults);
            }
        });

        this.splitDirection = 'horizontal';
        this.activatedRoute.paramMap.subscribe((params: ParamMap) => {
            const challengeId = +params.get('id')!;

            this.loadChallenge(challengeId);
        });
    }

    showTestResults(testResults: ITestsOutput) {
        if (testResults.isSuccess) {
            this.toastrNotification.showSuccess('Tests were successful!');
        } else {
            this.toastrNotification.showError('Tests failed');
        }
    }

    public runTests() {
        const codeRunRequest: ICodeRunRequest = {
            userId: 1234,
            challengeVersionId: 1234,
            isBuilt: true,
            language: 'csharp',
            userCode: 'public class Solution\r\n{\r\n    public bool IsNumPrime(int num)\r\n    ' +
                        '{\r\n        throw new Exception("Exception!!!");\r\n    }\r\n}\r\n',
            preloaded: undefined,
            tests: 'using NUnit.Framework;\r\n\r\n[TestFixture]\r\npublic class Tests\r\n{\r\n    ' +
                    'private Solution? _solutionClass;\r\n\r\n    [SetUp]\r\n    ' +
                    'public void Setup()\r\n    {\r\n        _solutionClass = new Solution();\r\n    }\r\n\r\n    ' +
                    '[Test]\r\n    public void IsPrime_InputIs1_ReturnFalse()\r\n    ' +
                    '{\r\n        var result = _solutionClass.IsNumPrime(2);\r\n\r\n        ' +
                    'Assert.IsFalse(result, "1 should not be prime");\r\n    }\r\n}',
        };

        this.toastrNotification.showInfo('Test run request sent');
        this.challengeService.runTests(codeRunRequest).subscribe();
    }

    onSelectedLanguageChanged($event: string | string[]): void {
        const selectedLang = this.mapLanguageName($event as string);

        this.initialSolution = this.getInitialSolutionByLanguage($event as string)!;

        this.languageVersions = this.getLanguageVersionsByLanguage(selectedLang);
        [this.selectedLanguageVersion] = this.languageVersions;
    }

    selectTab(title: string): void {
        this.activeTab = title;
    }

    isSelected(title: string): boolean {
        return this.activeTab === title;
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

        return (selectedVersion && selectedVersion.tests.length)
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
}
