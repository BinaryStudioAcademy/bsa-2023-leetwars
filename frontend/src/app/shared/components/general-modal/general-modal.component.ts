import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';

@Component({
    selector: 'app-general-modal',
    templateUrl: './general-modal.component.html',
    styleUrls: ['./general-modal.component.sass'],
})
export class GeneralModalComponent implements OnInit {
    @Input() isButtonVisible: boolean;
    constructor(public activeModal: NgbActiveModal) {}

    @Input() buttons: any[] = [];
    @Input() buttonClickHandler: (text: string) => void;

    @Output() newItemEvent = new EventEmitter<NgbActiveModal>();

    ngOnInit() {}
}
