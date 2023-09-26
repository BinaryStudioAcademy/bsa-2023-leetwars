import { Injectable } from '@angular/core';
import { CanDeactivate } from '@angular/router';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { ConfirmationModalComponent } from '@shared/components/confirmation-modal/confirmation-modal.component';
import { HasUnsavedChanges } from '@shared/models/unsaved-changes/has-unsaved-changes';

@Injectable({
    providedIn: 'root',
})
export class UnsavedChangesGuard<T extends HasUnsavedChanges> implements CanDeactivate<T> {
    constructor(
        private modalService: NgbModal,
    ) {}

    canDeactivate(component: T): Promise<boolean> {
        return component.unsavedChanges
            ? this.showConfirmationModal()
            : Promise.resolve(true);
    }

    private showConfirmationModal(): Promise<boolean> {
        const modalRef = this.modalService.open(ConfirmationModalComponent, { windowClass: 'delete-modal' });

        modalRef.componentInstance.titleText = 'Are you sure you want to leave this page?';
        modalRef.componentInstance.bodyText = 'All unsaved data will be lost.';

        return new Promise<boolean>((resolve) => {
            modalRef.componentInstance.buttons = [
                {
                    text: 'Yes',
                    handler: () => {
                        resolve(true);
                        modalRef.close();
                    },
                },
                {
                    text: 'Cancel',
                    handler: () => {
                        resolve(false);
                        modalRef.close();
                    },
                },
            ];
        });
    }
}
