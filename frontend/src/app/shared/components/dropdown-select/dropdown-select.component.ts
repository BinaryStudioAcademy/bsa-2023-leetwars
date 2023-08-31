import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { IconName } from '@fortawesome/fontawesome-svg-core';

@Component({
    selector: 'app-dropdown-select',
    templateUrl: './dropdown-select.component.html',
    styleUrls: ['./dropdown-select.component.sass'],
})
export class DropdownSelectComponent implements OnInit {
    @Input() isMultiSelection = false;

    @Input() title: string | undefined;

    @Input() items: string[] = [];

    @Input() selectText: string = 'Select';

    @Input() itemsIcons: IconName[] = [];

    @Output() SelectedItemsChanged: EventEmitter<string[] | string> = new EventEmitter<string[] | string>();

    @Input() selectedItem: string | undefined;

    public selectedIcon: IconName;

    public selectedItems: string[] = [];

    public ngOnInit() {
        this.updateSelectedIcon();
    }

    public toggleItem(item: string) {
        this.selectedItems = this.selectedItems.includes(item)
            ? this.selectedItems.filter((i) => i !== item)
            : [...this.selectedItems, item];

        this.SelectedItemsChanged.emit(this.selectedItems);
    }

    public selectItem(item: string) {
        this.selectedItem = item;
        this.updateSelectedIcon();
    }

    private updateSelectedIcon() {
        this.selectedIcon = this.itemsIcons[this.items.findIndex((i) => i === this.selectedItem)];
        this.SelectedItemsChanged.emit(this.selectedItem);
    }
}
