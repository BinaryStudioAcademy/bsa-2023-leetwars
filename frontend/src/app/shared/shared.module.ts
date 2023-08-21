import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';

import { LoadingSpinnerComponent } from './components/loading-spinner/loading-spinner.component';
import { NotFoundComponent } from './components/not-found/not-found.component';
import { ConfirmationModalComponent } from './components/confirmation-modal/confirmation-modal.component';
import { GeneralModalComponent } from './components/general-modal/general-modal.component';


@NgModule({
    imports: [CommonModule, RouterModule, FormsModule, ReactiveFormsModule, RouterModule],
    declarations: [LoadingSpinnerComponent, NotFoundComponent, ConfirmationModalComponent, GeneralModalComponent],
    exports: [
        CommonModule,
        RouterModule,
        FormsModule,
        ReactiveFormsModule,
        RouterModule,
        LoadingSpinnerComponent,
        NotFoundComponent,
        ConfirmationModalComponent,
        GeneralModalComponent
    ],
})
export class SharedModule {}
