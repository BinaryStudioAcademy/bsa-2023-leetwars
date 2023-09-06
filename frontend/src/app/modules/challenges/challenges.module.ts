import { LayoutModule } from '@angular/cdk/layout';
import { NgModule } from '@angular/core';
import { NgbModule, NgbNavModule } from '@ng-bootstrap/ng-bootstrap';
import { SharedModule } from '@shared/shared.module';
import { AngularSplitModule } from 'angular-split';
import { MarkdownModule } from 'ngx-markdown';
import { MonacoEditorModule, NgxMonacoEditorConfig } from 'ngx-monaco-editor-v2';

import { ChallengesDropdownSelectComponent } from './challenges-dropdown-select/challenges-dropdown-select.component';
import { ChallengesTestPageComponent } from './challenges-test-page/challenges-test-page.component';
import { EditorQuestionComponent } from './editor-question/editor-question.component';
import { OnlineEditorPageComponent } from './online-editor/online-editor-page/online-editor-page.component';
import { SolutionPageComponent } from './solution-page/solution-page.component';
import { StepsOfProgressComponent } from './steps-of-progress/steps-of-progress.component';
import { ChallengesRoutingModule } from './challenges-routing.module';

const monacoConfig: NgxMonacoEditorConfig = {
    baseUrl: '/assets',
    defaultOptions: { scrollBeyondLastLine: false },
    onMonacoLoad: () => {
        // eslint-disable-next-line @typescript-eslint/no-explicit-any
        (<any>window).monaco.editor.defineTheme('custom-theme', {
            base: 'vs-dark',
            inherit: true,
            rules: [],
            colors: {
                'editor.background': '#222327',
            },
        });
    },
};

@NgModule({
    declarations: [
        StepsOfProgressComponent,
        ChallengesTestPageComponent,
        ChallengesDropdownSelectComponent,
        EditorQuestionComponent,
        SolutionPageComponent,
        OnlineEditorPageComponent,
    ],
    imports: [SharedModule,
        ChallengesRoutingModule,
        NgbNavModule,
        NgbModule,
        LayoutModule,
        MarkdownModule.forRoot(),
        AngularSplitModule,
        MonacoEditorModule.forRoot(monacoConfig)],
})
export class ChallengesModule {}
