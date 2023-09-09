import { ChangeDetectorRef, Component, Input, OnInit } from '@angular/core';
import { IDropdownItem } from '@shared/models/dropdown-item';

import { Tab } from './tab';

@Component({
    selector: 'app-solution-page',
    templateUrl: './solution-page.component.html',
    styleUrls: ['./solution-page.component.sass'],
})
export class SolutionPageComponent implements OnInit {
    tabName: string = 'Complete solution';

    selectedLanguage: string = 'javascript';

    content: string;

    constructor(private changeDetector: ChangeDetectorRef) {}

    @Input() initialContent: string;

    @Input() preloadedContent: string;

    @Input() completedContent: string;

    languageItems: IDropdownItem[] = [{ content: 'JavaScript', iconName: 'node-js' }, { content: 'C#' }];

    languageVersionItems: IDropdownItem[] = [{ content: 'Node v18.x' }, { content: 'Node v17.x' }];

    tabs: Tab[] = [
        {
            title: 'Complete solution',
            active: true,
            disabled: false,
            customClass: 'customClass',
        },
        {
            title: 'Initial solution',
            active: false,
            disabled: false,
            customClass: 'customClass',
        },
        {
            title: 'Preloaded',
            active: false,
            disabled: false,
            customClass: 'customClass',
        },
    ];

    ngOnInit(): void {
        this.selectedLanguage = this.mapLanguageName(this.languageItems[0].content);
        this.content = this.completedContent;
    }

    languageChanged(item: IDropdownItem): void {
        this.selectedLanguage = this.mapLanguageName(item.content);
        this.changeDetector.detectChanges();
    }

    public onCodeChange(code: string) {
        this.content = code;

        switch (this.tabName) {
            case 'Complete solution':
                this.completedContent = code;
                break;
            case 'Initial solution':
                this.initialContent = code;
                break;
            case 'Preloaded':
                this.preloadedContent = code;
                break;
            default:
                break;
        }
    }

    switchTab(tabName: string): void {
        this.tabName = tabName;

        switch (tabName) {
            case 'Complete solution':
                this.content = this.completedContent;
                break;
            case 'Initial solution':
                this.content = this.initialContent;
                break;
            case 'Preloaded':
                this.content = this.preloadedContent;
                break;
            default:
                break;
        }
    }

    private languageNameMapping: { [key: string]: string } = {
        'C#': 'csharp',
    };

    private mapLanguageName(language: string): string {
        return this.languageNameMapping[language] || language.toLowerCase();
    }
}
