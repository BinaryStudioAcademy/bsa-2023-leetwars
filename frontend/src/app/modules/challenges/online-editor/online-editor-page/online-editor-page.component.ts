import { BreakpointObserver } from '@angular/cdk/layout';
import { Component, OnDestroy, OnInit } from '@angular/core';
import { ActivatedRoute, ParamMap, Router } from '@angular/router';
import { ChallengeService } from '@core/services/challenge.service';
import { languageNameMap } from '@shared/mappings/language-map';
import { Challenge } from '@shared/models/challenge/challenge';
import { ChallengeVersion } from '@shared/models/challenge-version/challenge-version';
import { EditorOptions } from '@shared/models/options/editor-options';
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

    challenge: Challenge;

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
        private router: Router,
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
        this.splitDirection = 'horizontal';
        this.activatedRoute.paramMap.subscribe((params: ParamMap) => {
            const challengeId = +params.get('id')!;

            this.loadChallenge(challengeId);
        });
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
            () => {
                this.router.navigateByUrl('/not-found');
            },
        );
    }

    private setupLanguages(challenge: Challenge) {
        this.challenge = challenge;
        this.languages = challenge.versions.map((v) => v.language.name);
        this.languageVersions = this.extractLanguageVersions(challenge.versions);
        [this.selectedLanguage] = this.languages;
        [this.selectedLanguageVersion] = this.languageVersions;
    }

    private extractLanguageVersions(versions: ChallengeVersion[]) {
        return versions.flatMap((version) =>
            version.language.languageVersions.map((languageVersion) => languageVersion.version));
    }

    private setupEditorOptions() {
        this.editorOptions = {
            theme: 'custom-theme',
            language: this.mapLanguageName(this.selectedLanguage),
            minimap: { enabled: false },
            automaticLayout: true,
            useShadows: false,
            wordWrap: 'on',
            lineNumbers: 'on',
        };
        this.initialSolution = this.getInitialSolutionByLanguage(this.selectedLanguage);
        this.testCode = this.getInitialTestByChallengeVersionId(this.challenge.versions[0].id);
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

    ngOnDestroy(): void {
        this.destroyed$.next();
        this.destroyed$.complete();
    }
}
