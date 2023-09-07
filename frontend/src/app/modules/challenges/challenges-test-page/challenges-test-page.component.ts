import { ChangeDetectorRef, Component } from '@angular/core';
import { IDropdownItem } from '@shared/models/dropdown-item';

@Component({
    selector: 'app-challenges-test-page',
    templateUrl: './challenges-test-page.component.html',
    styleUrls: ['./challenges-test-page.component.sass'],
})
export class ChallengesTestPageComponent {
    public languagesList: IDropdownItem[] = [{ content: 'JavaScript', iconName: 'node-js' }, { content: 'C#' }];

    public languageVersionsList: IDropdownItem[] = [{ content: 'Node v18.x' }, { content: 'Node v17.x' }];

    public tabs = [
        { title: 'Test Cases', active: true },
        { title: 'Example Test Cases', content: 'Example Test Cases content' },
        { title: 'Help', content: 'Help infomation' },
    ];

    public selectedLanguage: string;

    public isMaximized: boolean = false;

    private languageNameMapping: { [key: string]: string } = {
        'C#': 'csharp',
    };

    constructor(private cdr: ChangeDetectorRef) {}

    toggleMaximize() {
        this.isMaximized = !this.isMaximized;
    }

    onSelectedItemChanged(selectedItem: IDropdownItem) {
        this.selectedLanguage = this.mapLanguageName(selectedItem.content);
        this.cdr.detectChanges();
    }

    private mapLanguageName(language: string): string {
        return this.languageNameMapping[language] || language.toLowerCase();
    }
}
