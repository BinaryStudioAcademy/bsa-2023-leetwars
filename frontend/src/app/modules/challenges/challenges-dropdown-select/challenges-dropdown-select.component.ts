import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { DropdownItem } from '@shared/models/dropdown-item';

@Component({
    selector: 'app-challenges-dropdown-select',
    templateUrl: './challenges-dropdown-select.component.html',
    styleUrls: ['./challenges-dropdown-select.component.sass'],
})
export class ChallengesDropdownSelectComponent implements OnInit {
    @Input() items: DropdownItem[] = [];

    @Output() selectedItemsChanged: EventEmitter<DropdownItem> = new EventEmitter<DropdownItem>();

    selectedItem: DropdownItem;

    ngOnInit(): void {
        [this.selectedItem] = this.items;
        this.selectedItemsChanged.emit(this.selectedItem);
    }

    selectItem(item: DropdownItem) {
        this.selectedItem = item;
        this.selectedItemsChanged.emit(this.selectedItem);
    }
}
