import { BreakpointObserver } from '@angular/cdk/layout';
import { Component, OnDestroy, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { BroadcastHubService } from '@core/hubs/broadcast-hub.service';
import { ChallengeService } from '@core/services/challenge.service';
import { ToastrNotificationsService } from '@core/services/toastr-notifications.service';
import { Challenge } from '@shared/models/challenge/challenge';
import { CodeRunRequest } from '@shared/models/code-run-request/code-run-request';
import { CodeRunResults } from '@shared/models/code-run-results/code-run-results';
import { TestsOutput } from '@shared/models/tests-output/tests-output';
import { IChallenge } from '@shared/models/challenge/challenge';
import { Subject, takeUntil } from 'rxjs';

@Component({
    selector: 'app-online-editor-page',
    templateUrl: './online-editor-page.component.html',
    styleUrls: ['./online-editor-page.component.sass'],
})
export class OnlineEditorPageComponent implements OnDestroy, OnInit {
    private destroyed$: Subject<void> = new Subject<void>();

    activeTab: string = 'Description';

    splitDirection: 'horizontal' | 'vertical';

    splitLeftMinSize: number = 20;

    splitRightMinSize: number = 20;

    challenge: IChallenge;

    selectedLanguage: string;

    languageNameMap: Map<string, string> = new Map<string, string>([['C#', 'csharp']]);

    languages: string[];

    editorOptions: object;

    initialSolution: string | undefined;

    constructor(
        private activatedRoute: ActivatedRoute,
        private challengeService: ChallengeService,
        breakpointObserver: BreakpointObserver,
        private router: Router,
        private signalRService: BroadcastHubService,
        private toastrNotification: ToastrNotificationsService,
    ) {
        breakpointObserver
            .observe(['(max-width: 843px)'])
            .pipe(takeUntil(this.destroyed$))
            .subscribe((result) => {
                if (result.matches) {
                    this.splitDirection = 'vertical';
                } else {
                    this.splitDirection = 'horizontal';
                }
            });
    }

    ngOnInit() {
        this.signalRService.start();

        this.signalRService.listenMessages((message: string) => {
            const codeRunResults: CodeRunResults = JSON.parse(message);

            if (codeRunResults.isBuilt && codeRunResults.testRunResults !== null && codeRunResults.testRunResults !== '') {
                this.showTestResults(codeRunResults.testRunResults);
            }
        });

        const challengeId = this.activatedRoute.snapshot.params['id'];

        this.splitDirection = 'horizontal';

        this.challengeService.getChallengeById(challengeId).subscribe({
            next: (challenge) => {
                this.languages = challenge.versions.map((v) => v.language.name);
                this.challenge = challenge;
                [this.selectedLanguage] = this.languages;
                this.editorOptions = {
                    theme: 'custom-theme',
                    language: this.mapLanguageName(this.selectedLanguage),
                    minimap: { enabled: false },
                    automaticLayout: true,
                    useShadows: false,
                    wordWrap: 'on',
                };
                this.initialSolution = this.getInitialSolutionByLanguage(this.selectedLanguage);
            },
            error: () => {
                this.router.navigateByUrl('/not-found');
            },
        });
    }

    onSelectedLanguageChanged($event: string | string[]): void {
        const selectedLang = this.mapLanguageName($event as string);

        this.initialSolution = this.getInitialSolutionByLanguage($event as string);

        // eslint-disable-next-line @typescript-eslint/no-explicit-any
        (<any>window).monaco.editor.setModelLanguage((<any>window).monaco.editor.getModels()[0], selectedLang);
    }

    showTestResults(testOutput: string) {
        const testResults: TestsOutput = JSON.parse(testOutput);

        if (testResults.isSuccess) {
            this.toastrNotification.showSuccess('Tests were successful!');
        } else if (!testResults.isSuccess) {
            this.toastrNotification.showError('Tests failed');
        }
    }

    selectTab(title: string): void {
        this.activeTab = title;
    }

    isSelected(title: string): boolean {
        return this.activeTab === title;
    }

    private getInitialSolutionByLanguage(language: string): string | undefined {
        const version = this.challenge.versions.find((v) => v.language.name === language);

        return version?.initialSolution;
    }

    private mapLanguageName(language: string): string {
        return this.languageNameMap.get(language) || language.toLowerCase();
    }

    public runTests() {
        const codeRunRequest: CodeRunRequest = {
            userId: 1234,
            challengeVersionId: 1234,
            isBuilt: true,
            language: 'csharp',
            userCode: 'public class Solution\r\n{\r\n    public bool IsNumPrime(int num)\r\n    ' +
                        '{\r\n        throw new Exception("Exception!!!");\r\n    }\r\n}\r\n',
            preloaded: null,
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

    ngOnDestroy(): void {
        this.destroyed$.next();
        this.destroyed$.complete();
    }
}
