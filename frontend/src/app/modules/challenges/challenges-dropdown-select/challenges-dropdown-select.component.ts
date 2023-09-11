import { Component, EventEmitter, Input, Output } from '@angular/core';
import { IDropdownItem } from '@shared/models/dropdown-item';
import { getLanguageIconUrl } from '@shared/utils/language-icons';

@Component({
    selector: 'app-challenges-dropdown-select',
    templateUrl: './challenges-dropdown-select.component.html',
    styleUrls: ['./challenges-dropdown-select.component.sass'],
})

export class ChallengesDropdownSelectComponent {
    @Input() items: IDropdownItem[] = [];
  
    @Input() selectedItem?: DropdownItem;

    @Output() selectedItemsChanged: EventEmitter<IDropdownItem> = new EventEmitter<IDropdownItem>();

    selectItem(item: IDropdownItem) {
        this.selectedItem = item;
        this.selectedItemChanged.emit(this.selectedItem);
    }

    protected readonly getLanguageIconUrl = getLanguageIconUrl;
}
