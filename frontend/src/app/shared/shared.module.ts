import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { FaIconLibrary, FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { fab } from '@fortawesome/free-brands-svg-icons';
import { far } from '@fortawesome/free-regular-svg-icons';
import { fas } from '@fortawesome/free-solid-svg-icons';

import { LoadingSpinnerComponent } from './components/loading-spinner/loading-spinner.component';
import { NotFoundComponent } from './components/not-found/not-found.component';
import { ConfirmationModalComponent } from './components/confirmation-modal/confirmation-modal.component';
import { GeneralModalComponent } from './components/general-modal/general-modal.component';


@NgModule({
<<<<<<< HEAD
    imports: [CommonModule, RouterModule, FormsModule, ReactiveFormsModule, RouterModule],
    declarations: [LoadingSpinnerComponent, NotFoundComponent, ConfirmationModalComponent, GeneralModalComponent],
=======
    imports: [CommonModule, RouterModule, FormsModule, ReactiveFormsModule, RouterModule, FontAwesomeModule],
    declarations: [LoadingSpinnerComponent, NotFoundComponent],
>>>>>>> dev
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
        GeneralModalComponent
    ],
})
export class SharedModule {
    constructor(library: FaIconLibrary) {
        library.addIconPacks(fas, fab, far);
    }
}
