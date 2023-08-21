import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';

@Component({
    selector: 'confirmation-modal',
    templateUrl: './confirmation-modal.component.html',
})
export class ConfirmationModalComponent implements OnInit {
    constructor(public activeModal: NgbActiveModal) {}

    @Input() buttons: any[] = [];
    @Input() buttonClickHandler: (text: string) => void;

    @Output() newItemEvent = new EventEmitter<NgbActiveModal>();

    ngOnInit() {}
}
