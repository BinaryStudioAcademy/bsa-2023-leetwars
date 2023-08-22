import { Component, EventEmitter, Input, Output } from '@angular/core';

@Component({
    selector: 'app-dropdown-select',
    templateUrl: './dropdown-select.component.html',
    styleUrls: ['./dropdown-select.component.sass'],
})
export class DropdownSelectComponent {
    @Input() isMultiSelection = false;

    @Input() title: string;

    @Input() items: string[] = [];

    @Output() SelectedItemsChanged: EventEmitter<string[] | string> = new EventEmitter<string[] | string>();

    selectedItem: string | undefined;

    selectedItems: string[] = [];

    toggleItem(item: string) {
        this.selectedItems = this.selectedItems.includes(item)
            ? this.selectedItems.filter((i) => i !== item)
            : [...this.selectedItems, item];

        this.SelectedItemsChanged.emit(this.selectedItems);
    }

    selectItem(item: string) {
        this.selectedItem = item;
        this.SelectedItemsChanged.emit(this.selectedItem);
    }
}
