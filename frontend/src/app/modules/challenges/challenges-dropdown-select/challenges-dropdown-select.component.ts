import { Component, EventEmitter, Input, Output } from '@angular/core';
import { DropdownItem } from '@shared/models/dropdown-item';

@Component({
    selector: 'app-challenges-dropdown-select',
    templateUrl: './challenges-dropdown-select.component.html',
    styleUrls: ['./challenges-dropdown-select.component.sass'],
})
export class ChallengesDropdownSelectComponent {
    @Input() items: DropdownItem[] = [];

    @Input() selectedItem?: DropdownItem;

    @Output() selectedItemChanged = new EventEmitter<DropdownItem>();

    selectItem(item: DropdownItem) {
        this.selectedItem = item;
        this.selectedItemChanged.emit(this.selectedItem);
    }
}
