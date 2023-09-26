import { LayoutModule } from '@angular/cdk/layout';
import { NgModule } from '@angular/core';
import { UnsavedChangesGuard } from '@core/guards/unsaved-changes.guard';
import { NgbModule, NgbNavModule } from '@ng-bootstrap/ng-bootstrap';
import { monacoConfig } from '@shared/configurations/monaco-config';
import { SharedModule } from '@shared/shared.module';
import { AngularSplitModule } from 'angular-split';
import { MarkdownModule } from 'ngx-markdown';
import { MonacoEditorModule } from 'ngx-monaco-editor-v2';

import { ChallengeCreationComponent } from './challenge-creation/challenge-creation.component';
import { ChallengesDropdownSelectComponent } from './challenges-dropdown-select/challenges-dropdown-select.component';
import { ChallengesTestPageComponent } from './challenges-test-page/challenges-test-page.component';
import { EditorQuestionComponent } from './editor-question/editor-question.component';
import { OnlineEditorPageComponent } from './online-editor-page/online-editor-page.component';
import { SolutionPageComponent } from './solution-page/solution-page.component';
import { StepsOfProgressComponent } from './steps-of-progress/steps-of-progress.component';
import { ChallengesRoutingModule } from './challenges-routing.module';

@NgModule({
    declarations: [
        StepsOfProgressComponent,
        ChallengesTestPageComponent,
        EditorQuestionComponent,
        SolutionPageComponent,
        ChallengeCreationComponent,
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
    providers: [
        UnsavedChangesGuard,
    ],
})
export class ChallengesModule {}
