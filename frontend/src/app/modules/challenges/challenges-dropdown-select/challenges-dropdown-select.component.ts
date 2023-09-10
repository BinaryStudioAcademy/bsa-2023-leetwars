import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { IDropdownItem } from '@shared/models/dropdown-item';

@Component({
    selector: 'app-challenges-dropdown-select',
    templateUrl: './challenges-dropdown-select.component.html',
    styleUrls: ['./challenges-dropdown-select.component.sass'],
})
export class ChallengesDropdownSelectComponent implements OnInit {
    @Input() items: IDropdownItem[] = [];

    @Output() selectedItemsChanged: EventEmitter<IDropdownItem> = new EventEmitter<IDropdownItem>();

    selectedItem: IDropdownItem;

    ngOnInit(): void {
        [this.selectedItem] = this.items;
        this.selectedItemsChanged.emit(this.selectedItem);
    }

    selectItem(item: IDropdownItem) {
        this.selectedItem = item;
        this.selectedItemsChanged.emit(this.selectedItem);
    }
}
