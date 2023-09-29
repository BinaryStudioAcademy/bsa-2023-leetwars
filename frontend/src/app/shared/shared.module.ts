import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { ClickOutsideDirective } from '@core/directives/click-outside.directive';
import { ScrollToDirective } from '@core/directives/scroll-to.directive';
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
import { ToastrModule } from 'ngx-toastr';

import { ArrowUpComponent } from './components/arrow-up/arrow-up.component';
import { CodeEditorComponent } from './components/code-editor/code-editor.component';
import { ConfirmationModalComponent } from './components/confirmation-modal/confirmation-modal.component';
import { CustomInputComponent } from './components/custom-input/custom-input.component';
import { CustomToastrNotificationComponent } from './components/custom-toastr-notification/custom-toastr-notification.component';
import { DropdownSelectComponent } from './components/dropdown-select/dropdown-select.component';
import { GeneralModalComponent } from './components/general-modal/general-modal.component';
import { HeaderComponent } from './components/header/header.component';
import { LoadingSpinnerComponent } from './components/loading-spinner/loading-spinner.component';
import { NotFoundComponent } from './components/not-found/not-found.component';
import { NotificationsComponent } from './components/notifications/notifications.component';
import { PieChartComponent } from './components/pie-chart/pie-chart.component';
import { ProgressBarComponent } from './components/progress-bar/progress-bar.component';
import { SolutionSubmitModalComponent } from './components/solution-submit-modal/solution-submit-modal.component';
import { toastrGlobalConfig } from './configurations/toastr-global-config';

@NgModule({
    imports: [
        CommonModule,
        RouterModule,
        FormsModule,
        ReactiveFormsModule,
        RouterModule,
        FontAwesomeModule,
        NgxChartsModule,
        NgbModule,
        MonacoEditorModule,
        InfiniteScrollModule,
        ProgressbarModule,
        MarkdownModule.forRoot(),
        ToastrModule.forRoot(toastrGlobalConfig),
        AngularMarkdownEditorModule.forRoot({ iconlibrary: 'fa' }),
    ],
    declarations: [
        LoadingSpinnerComponent,
        PieChartComponent,
        NotFoundComponent,
        ConfirmationModalComponent,
        GeneralModalComponent,
        DropdownSelectComponent,
        CustomInputComponent,
        CodeEditorComponent,
        ProgressBarComponent,
        NotificationsComponent,
        HeaderComponent,
        SolutionSubmitModalComponent,
        ArrowUpComponent,
        ScrollToDirective,
        ClickOutsideDirective,
        CustomToastrNotificationComponent,
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
        PieChartComponent,
        CodeEditorComponent,
        ConfirmationModalComponent,
        GeneralModalComponent,
        DropdownSelectComponent,
        CustomInputComponent,
        ProgressBarComponent,
        HeaderComponent,
        ArrowUpComponent,
        NgbModule,
        TabsModule,
        MarkdownModule,
        AngularMarkdownEditorModule,
        InfiniteScrollModule,
        ScrollToDirective,
        ClickOutsideDirective,
    ],
    providers: [TabsetConfig],
})
export class SharedModule {
    constructor(library: FaIconLibrary) {
        library.addIconPacks(fas, fab, far);
    }
}
