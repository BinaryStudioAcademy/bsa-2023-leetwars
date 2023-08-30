import { ChangeDetectorRef, Component } from '@angular/core';
import { DropdownItem } from '@shared/models/dropdown-item';

@Component({
    selector: 'app-challenges-test-page',
    templateUrl: './challenges-test-page.component.html',
    styleUrls: ['./challenges-test-page.component.sass'],
})
export class ChallengesTestPageComponent {
    public languagesList: DropdownItem[] = [{ content: 'JavaScript', iconName: 'node-js' }, { content: 'C#' }];

    public languageVersionsList: DropdownItem[] = [{ content: 'Node v18.x' }, { content: 'Node v17.x' }];

    public selectedLanguage: string;

    public activeTab: string = 'test-cases';

    public isMaximized: boolean = false;

    private languageNameMapping: { [key: string]: string } = {
        'C#': 'csharp',
    };

    constructor(private cdr: ChangeDetectorRef) {}

    changeTab(tab: string) {
        this.activeTab = tab;
    }

    toggleMaximize() {
        this.isMaximized = !this.isMaximized;
    }

    onSelectedItemChanged(selectedItem: DropdownItem) {
        this.selectedLanguage = this.mapLanguageName(selectedItem.content);
        this.cdr.detectChanges();
    }

    private mapLanguageName(language: string): string {
        return this.languageNameMapping[language] || language.toLowerCase();
    }
}
