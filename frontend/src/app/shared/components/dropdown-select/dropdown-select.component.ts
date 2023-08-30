import { Component, EventEmitter, Input, OnChanges, OnInit, Output, SimpleChanges } from '@angular/core';

@Component({
    selector: 'app-dropdown-select',
    templateUrl: './dropdown-select.component.html',
    styleUrls: ['./dropdown-select.component.sass'],
})
export class DropdownSelectComponent implements OnChanges {
    @Input() isMultiSelection = false;

    @Input() title: string;

    @Input() items: string[] = [];

    @Input() initialValue: string;

    @Output() SelectedItemsChanged = new EventEmitter<string[] | string>();

    selectedItem: string;

    selectedItems: string[] = [];

    fieldText = '';

    ngOnChanges(changes: SimpleChanges): void {
        if (changes['initialValue']) {
            this.setInitialValue();
        }
    }

    setInitialValue() {
        if (this.isMultiSelection) {
            this.selectedItems = [this.initialValue];
        }
        if (!this.isMultiSelection) {
            this.selectedItem = this.initialValue;
        }
        this.fieldText = this.initialValue;
    }

    toggleItem(item: string) {
        this.selectedItems = this.selectedItems.includes(item)
            ? this.selectedItems.filter((i) => i !== item)
            : [...this.selectedItems, item];

        this.fieldText = this.selectedItems.join(', ');
        this.SelectedItemsChanged.emit(this.selectedItems);
    }

    selectItem(item: string) {
        this.selectedItem = item;
        this.fieldText = item;
        this.SelectedItemsChanged.emit(this.selectedItem);
    }
}
