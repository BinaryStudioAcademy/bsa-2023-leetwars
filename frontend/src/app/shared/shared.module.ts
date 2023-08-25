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
import { MonacoEditorModule } from 'ngx-monaco-editor-v2';

import { ChallengeComponent } from './components/challenge/challenge.component';
import { CodeEditorComponent } from './components/code-editor/code-editor.component';
import { ConfirmationModalComponent } from './components/confirmation-modal/confirmation-modal.component';
import { CustomInputComponent } from './components/custom-input/custom-input.component';
import { DropdownSelectComponent } from './components/dropdown-select/dropdown-select.component';
import { FilteringSectionComponent } from './components/filtering-section/filtering-section.component';
import { GeneralModalComponent } from './components/general-modal/general-modal.component';
import { LoadingSpinnerComponent } from './components/loading-spinner/loading-spinner.component';
import { NotFoundComponent } from './components/not-found/not-found.component';
import { SuggestedChallengeComponent } from './components/suggested-challenge/suggested-challenge.component';

@NgModule({
    imports: [CommonModule, RouterModule, FormsModule, ReactiveFormsModule, RouterModule, FontAwesomeModule, NgbModule, NgxChartsModule, MonacoEditorModule],
    declarations: [
        LoadingSpinnerComponent,
        NotFoundComponent,
        ConfirmationModalComponent,
        GeneralModalComponent,
        DropdownSelectComponent,
        SuggestedChallengeComponent,
        CustomInputComponent,
        CodeEditorComponent,
        ChallengeComponent,
        FilteringSectionComponent,
    ],
    exports: [
        CommonModule,
        RouterModule,
        FormsModule,
        ReactiveFormsModule,
        RouterModule,
        FontAwesomeModule,
        NgxChartsModule,
        LoadingSpinnerComponent,
        NotFoundComponent,
        CodeEditorComponent,
        ConfirmationModalComponent,
        GeneralModalComponent,
        DropdownSelectComponent,
        SuggestedChallengeComponent,
        CustomInputComponent,
        ChallengeComponent,
        FilteringSectionComponent,
    ],
})
export class SharedModule {
    constructor(library: FaIconLibrary) {
        library.addIconPacks(fas, fab, far);
    }
}
