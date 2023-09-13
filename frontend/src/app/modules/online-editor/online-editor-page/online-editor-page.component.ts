import { BreakpointObserver } from '@angular/cdk/layout';
import { Component, OnDestroy, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { CodeDisplayingHubService } from '@core/hubs/code-displaying-hub.service';
import { ChallengeService } from '@core/services/challenge.service';
import { ToastrNotificationsService } from '@core/services/toastr-notifications.service';
import { IChallenge } from '@shared/models/challenge/challenge';
import { ICodeRunRequest } from '@shared/models/code-run/code-run-request';
import { ICodeRunResults } from '@shared/models/code-run/code-run-result';
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

    solution: ICodeRunRequest;

    constructor(
        private activatedRoute: ActivatedRoute,
        private challengeService: ChallengeService,
        breakpointObserver: BreakpointObserver,
        private router: Router,
        private signalRService: CodeDisplayingHubService,
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
        const challengeId = this.activatedRoute.snapshot.params['id'];

        this.splitDirection = 'horizontal';

        this.subscribeToMessageQueue();
        this.loadChallenge(challengeId);

    }

    onSelectedLanguageChanged($event: string | string[]): void {
        const selectedLang = this.mapLanguageName($event as string);

        this.selectedLanguage = selectedLang;

        this.initialSolution = this.getInitialSolutionByLanguage($event as string);

        // eslint-disable-next-line @typescript-eslint/no-explicit-any
        (<any>window).monaco.editor.setModelLanguage((<any>window).monaco.editor.getModels()[0], selectedLang);
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

    sendCode(): void {
        this.solution = {
            userConnectionId: this.signalRService.connectionId,
            challengeVersionId: this.challenge.id,
            language: this.selectedLanguage,
            userCode: this.initialSolution as string,
        };

        this.challengeService.postCode(this.solution).subscribe();
    }

    loadChallenge(challengeId: number): void {
        this.challengeService.getChallengeById(challengeId).subscribe({
            next: (challenge) => {
                this.challenge = challenge;
                this.setupEditor(this.challenge);
            },
            error: () => {
                this.router.navigateByUrl('/not-found');
            },
        });
    }

    setupEditor(challenge: IChallenge): void {
        this.languages = challenge.versions.map((v) => v.language.name);
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

    ngOnDestroy(): void {
        this.signalRService.stop();
        this.destroyed$.next();
        this.destroyed$.complete();
    }
}
