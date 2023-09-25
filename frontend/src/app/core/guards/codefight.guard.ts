import { Injectable } from '@angular/core';
import { CanDeactivate, Router } from '@angular/router';
import { ToastrNotificationsService } from '@core/services/toastr-notifications.service';
import { OnlineEditorPageComponent } from '@modules/challenges/online-editor-page/online-editor-page.component';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { ConfirmationModalComponent } from '@shared/components/confirmation-modal/confirmation-modal.component';

@Injectable({
    providedIn: 'root',
})
export class CodefightGuard implements CanDeactivate<OnlineEditorPageComponent> {
    constructor(
        private modalService: NgbModal,
        private router: Router,
        private toastrService: ToastrNotificationsService,
    ) {}

    public canDeactivate() {
        const modalRef = this.modalService.open(ConfirmationModalComponent);

        modalRef.componentInstance.titleText = 'Do you really wish to give up?';
        modalRef.componentInstance.bodyText = 'After confirmation you will lose this code fight';
        modalRef.componentInstance.buttons = [
            {
                text: 'Yes',
                handler: () => {
                    this.toastrService.showInfo('You have lost the code fight');
                    modalRef.close();

                    modalRef.closed.subscribe(() => {
                        this.router.navigate(['/']);
                    });
                },
            },
            {
                text: 'No',
                handler: () => {
                    modalRef.dismiss();
                },
            },
        ];

        return modalRef.closed;
    }
}
