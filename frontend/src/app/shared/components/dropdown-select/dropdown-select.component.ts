import { Component, EventEmitter, Input, OnChanges, OnInit, Output, SimpleChanges } from '@angular/core';
import { IconName } from '@fortawesome/fontawesome-svg-core';

@Component({
    selector: 'app-dropdown-select',
    templateUrl: './dropdown-select.component.html',
    styleUrls: ['./dropdown-select.component.sass'],
})
export class DropdownSelectComponent implements OnInit, OnChanges {
    @Input() isMultiSelection = false;

    @Input() title: string | undefined;

    @Input() items: string[] = [];

    @Input() selectText: string = 'Select';

    @Input() itemsIcons: IconName[] = [];

    @Input() selectedItem: string;

    @Input() selectedItems: string[] = [];

    @Output() selectedItemsChanged = new EventEmitter<string[] | string>();

    public selectedIcon: IconName;

    public fieldText = '';

    ngOnChanges({ selectedItem, selectedItems }: SimpleChanges): void {
        if (selectedItem) {
            this.setInitialValue();
        }
        if (selectedItems) {
            this.fieldText = this.selectedItems.join(', ');
        }
    }

    private allSelectionName = 'All';

    public ngOnInit() {
        this.updateSelectedIcon();
    }

    public isSelectedTextNotDefault() {
        return this.selectText !== 'Select';
    }

    public toggleItem(item: string) {
        const isAllSelected = this.selectedItems.includes(this.allSelectionName);

        if (item === this.allSelectionName) {
            this.selectedItems = isAllSelected ? [] : [item];
            this.updateSelectedItems();

            return;
        }

        if (isAllSelected) {
            this.selectedItems = this.selectedItems.filter((i) => i !== this.allSelectionName);
        }

        this.setSelectedItems(item);
        this.updateSelectedItems();
    }

    public selectItem(item: string) {
        this.selectedItem = item;
        this.fieldText = item;
        this.selectedItemsChanged.emit(this.selectedItem);
        this.updateSelectedIcon();
    }

    private setInitialValue() {
        if (this.isMultiSelection) {
            this.selectedItems = [this.selectedItem];
        }
        this.fieldText = this.selectedItem;
    }

    private updateSelectedIcon() {
        this.selectedIcon = this.itemsIcons[this.items.findIndex((i) => i === this.selectedItem)];
    }

    private setSelectedItems(item: string) {
        this.selectedItems = this.selectedItems.includes(item)
            ? this.selectedItems.filter((i) => i !== item)
            : [...this.selectedItems, item];
    }

    private updateSelectedItems() {
        this.fieldText = this.selectedItems.join(', ');
        this.selectedItemsChanged.emit(this.selectedItems);
    }
}
