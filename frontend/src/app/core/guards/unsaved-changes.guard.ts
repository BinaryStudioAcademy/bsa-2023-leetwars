import { Injectable } from '@angular/core';
import { CanDeactivate } from '@angular/router';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { ConfirmationModalComponent } from '@shared/components/confirmation-modal/confirmation-modal.component';
import { HasUnsavedChanges } from '@shared/models/unsaved-changes/has-unsaved-changes';

@Injectable({
    providedIn: 'root',
})
export class UnsavedChangesGuard<T extends HasUnsavedChanges> implements CanDeactivate<T> {
    constructor(private modalService: NgbModal) {}

    canDeactivate(component: T) {
        return component.unsavedChanges ? this.showConfirmationModal() : true;
    }

    private showConfirmationModal() {
        const modalRef = this.modalService.open(ConfirmationModalComponent, { windowClass: 'delete-modal' });

        modalRef.componentInstance.titleText = 'Are you sure you want to leave this page?';
        modalRef.componentInstance.bodyText = 'All unsaved data will be lost.';

        modalRef.componentInstance.buttons = [
            {
                text: 'Yes',
                handler: () => {
                    modalRef.close();
                },
            },
            {
                text: 'Cancel',
                handler: () => {
                    modalRef.dismiss();
                },
            },
        ];

        return modalRef.closed;
    }
}
