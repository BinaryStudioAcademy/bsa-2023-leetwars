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

    @Output() SelectedItemsChanged = new EventEmitter<string[] | string>();

    public selectedIcon: IconName;

    fieldText = '';

    ngOnChanges(changes: SimpleChanges): void {
        if (changes['selectedItem']) {
            this.setInitialValue();
        }
    }

    setInitialValue() {
        if (this.isMultiSelection) {
            this.selectedItems = [this.selectedItem];
        }
        this.fieldText = this.selectedItem;
    }

    public selectedItems: string[] = [];

    public ngOnInit() {
        this.updateSelectedIcon();
    }

    public toggleItem(item: string) {
        this.selectedItems = this.selectedItems.includes(item)
            ? this.selectedItems.filter((i) => i !== item)
            : [...this.selectedItems, item];

        this.fieldText = this.selectedItems.join(', ');
        this.SelectedItemsChanged.emit(this.selectedItems);
    }

    public selectItem(item: string) {
        this.selectedItem = item;
        this.fieldText = item;
        this.SelectedItemsChanged.emit(this.selectedItem);
        this.updateSelectedIcon();
    }

    private updateSelectedIcon() {
        this.selectedIcon = this.itemsIcons[this.items.findIndex((i) => i === this.selectedItem)];
    }
}
