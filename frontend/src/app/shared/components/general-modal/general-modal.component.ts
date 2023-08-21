import { Component, ComponentRef, Input, Type } from '@angular/core';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';
import { ModalButton } from '@shared/models/modal-button';

@Component({
    selector: 'app-general-modal',
    templateUrl: './general-modal.component.html',
    styleUrls: ['./general-modal.component.sass'],
})
export class GeneralModalComponent<T> {
    constructor(public activeModal: NgbActiveModal) {}

    @Input() componentToDisplay: Type<ComponentRef<T>>;

    @Input() buttons: ModalButton[] = [];
}
