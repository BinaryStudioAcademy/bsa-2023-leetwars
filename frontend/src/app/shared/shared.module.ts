import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { FaIconLibrary, FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { fab } from '@fortawesome/free-brands-svg-icons';
import { far } from '@fortawesome/free-regular-svg-icons';
import { fas } from '@fortawesome/free-solid-svg-icons';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { NgxChartsModule } from '@swimlane/ngx-charts';
import { AngularMarkdownEditorModule } from 'angular-markdown-editor';
import { ProgressbarModule } from 'ngx-bootstrap/progressbar';
import { TabsetConfig, TabsModule } from 'ngx-bootstrap/tabs';
import { MarkdownModule } from 'ngx-markdown';
import { MonacoEditorModule } from 'ngx-monaco-editor-v2';

import { ChallengesDropdownSelectComponent } from './components/challenges-dropdown-select/challenges-dropdown-select.component';
import { CodeEditorComponent } from './components/code-editor/code-editor.component';
import { ConfirmationModalComponent } from './components/confirmation-modal/confirmation-modal.component';
import { CustomInputComponent } from './components/custom-input/custom-input.component';
import { DropdownSelectComponent } from './components/dropdown-select/dropdown-select.component';
import { GeneralModalComponent } from './components/general-modal/general-modal.component';
import { HeaderComponent } from './components/header/header.component';
import { LoadingSpinnerComponent } from './components/loading-spinner/loading-spinner.component';
import { NotFoundComponent } from './components/not-found/not-found.component';
import { PieChartComponent } from './components/pie-chart/pie-chart.component';
import { ProgressBarComponent } from './components/progress-bar/progress-bar.component';
import { SolutionComponent } from './components/solution/solution.component';

@NgModule({
    imports: [
        CommonModule,
        RouterModule,
        FormsModule,
        ReactiveFormsModule,
        RouterModule,
        FontAwesomeModule,
        NgbModule,
        MonacoEditorModule,
        NgxChartsModule,
        ProgressbarModule,
        TabsModule,
        MarkdownModule.forRoot(),
        AngularMarkdownEditorModule.forRoot({ iconlibrary: 'fa' }),

    ],
    declarations: [
        LoadingSpinnerComponent,
        NotFoundComponent,
        ConfirmationModalComponent,
        GeneralModalComponent,
        DropdownSelectComponent,
        CustomInputComponent,
        CodeEditorComponent,
        PieChartComponent,
        ProgressBarComponent,
        HeaderComponent,
        ChallengesDropdownSelectComponent,
        SolutionComponent,

    ],
    exports: [
        CommonModule,
        RouterModule,
        FormsModule,
        ReactiveFormsModule,
        RouterModule,
        FontAwesomeModule,
        LoadingSpinnerComponent,
        NotFoundComponent,
        CodeEditorComponent,
        ConfirmationModalComponent,
        GeneralModalComponent,
        DropdownSelectComponent,
        CustomInputComponent,
        PieChartComponent,
        ProgressBarComponent,
        HeaderComponent,
        SolutionComponent,
        NgbModule,
        TabsModule,
        MarkdownModule,
        AngularMarkdownEditorModule,
    ],
    providers: [TabsetConfig],
})
export class SharedModule {
    constructor(library: FaIconLibrary) {
        library.addIconPacks(fas, fab, far);
    }
}
