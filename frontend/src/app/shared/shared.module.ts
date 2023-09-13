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
import { InfiniteScrollModule } from 'ngx-infinite-scroll';
import { MarkdownModule } from 'ngx-markdown';
import { MonacoEditorModule } from 'ngx-monaco-editor-v2';
import { CarouselModule } from 'ngx-owl-carousel-o';

import { BadgeComponent } from './components/badge/badge.component';
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

@NgModule({
    imports: [
        CommonModule,
        RouterModule,
        FormsModule,
        ReactiveFormsModule,
        CarouselModule,
        RouterModule,
        FontAwesomeModule,
        NgbModule,
        MonacoEditorModule,
        InfiniteScrollModule,
        NgxChartsModule,
        ProgressbarModule,
        MarkdownModule.forRoot(),
        AngularMarkdownEditorModule.forRoot({ iconlibrary: 'fa' }),
        TabsModule,

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
        BadgeComponent,
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
        BadgeComponent,
        ProgressBarComponent,
        HeaderComponent,
        NgbModule,
        TabsModule,
        MarkdownModule,
        AngularMarkdownEditorModule,
        InfiniteScrollModule,
    ],
    providers: [TabsetConfig],
})
export class SharedModule {
    constructor(library: FaIconLibrary) {
        library.addIconPacks(fas, fab, far);
    }
}
