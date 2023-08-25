import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { FaIconLibrary, FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { fab } from '@fortawesome/free-brands-svg-icons';
import { far } from '@fortawesome/free-regular-svg-icons';
import { fas } from '@fortawesome/free-solid-svg-icons';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';

import { ChallengeComponent } from './components/challenge/challenge.component';
import { ConfirmationModalComponent } from './components/confirmation-modal/confirmation-modal.component';
import { CustomInputComponent } from './components/custom-input/custom-input.component';
import { DropdownSelectComponent } from './components/dropdown-select/dropdown-select.component';
import { FilteringSectionComponent } from './components/filtering-section/filtering-section.component';
import { GeneralModalComponent } from './components/general-modal/general-modal.component';
import { LoadingSpinnerComponent } from './components/loading-spinner/loading-spinner.component';
import { NotFoundComponent } from './components/not-found/not-found.component';
import { SuggestedChallengeComponent } from './components/suggested-challenge/suggested-challenge.component';
import { PieChartComponent } from './components/pie-chart/pie-chart.component';
import { NgxChartsModule } from '@swimlane/ngx-charts';
import { ProgressBarComponent } from './components/progress-bar/progress-bar.component';
import { ProgressbarModule }
    from 'ngx-bootstrap/progressbar';

@NgModule({
    imports: [CommonModule, RouterModule, FormsModule, ReactiveFormsModule, RouterModule, FontAwesomeModule, NgbModule, NgxChartsModule, ProgressbarModule.forRoot()],
    declarations: [
        LoadingSpinnerComponent,
        NotFoundComponent,
        ConfirmationModalComponent,
        GeneralModalComponent,
        DropdownSelectComponent,
        SuggestedChallengeComponent,
        CustomInputComponent,
        ChallengeComponent,
        FilteringSectionComponent,
        PieChartComponent,
        ProgressBarComponent
        
        
        
        
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
        ConfirmationModalComponent,
        GeneralModalComponent,
        DropdownSelectComponent,
        SuggestedChallengeComponent,
        CustomInputComponent,
        ChallengeComponent,
        FilteringSectionComponent,
        PieChartComponent,
        ProgressBarComponent
        
    ],
    
})
export class SharedModule {
    constructor(library: FaIconLibrary) {
        library.addIconPacks(fas, fab, far);
    }
}
