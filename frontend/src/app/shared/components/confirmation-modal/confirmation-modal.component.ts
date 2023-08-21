import { Component, Input, OnInit } from '@angular/core';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';
import { ModalButton } from '@shared/models/modal-button';

@Component({
    selector: 'confirmation-modal',
    templateUrl: './confirmation-modal.component.html',
})
export class ConfirmationModalComponent {
    constructor(public activeModal: NgbActiveModal) {}

    @Input() titleText: string;

    @Input() bodyText: string;

    @Input() buttons: ModalButton[] = [];
}
