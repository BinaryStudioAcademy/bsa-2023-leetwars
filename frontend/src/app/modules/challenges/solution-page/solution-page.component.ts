import { Component, Input, OnInit } from '@angular/core';
import { DropdownItem } from '@shared/models/dropdown-item';

import { Tab } from './tab';

@Component({
    selector: 'app-solution-page',
    templateUrl: './solution-page.component.html',
    styleUrls: ['./solution-page.component.sass'],
})
export class SolutionPageComponent implements OnInit {
    tabName: string = 'Complete solution';

    selectedLanguage: string = 'C#';

    content: string;

    @Input() initialContent: string = 'initial';

    @Input() preloadedContent: string = 'preloaded';

    @Input() completedContent: string = 'complete';

    languageItems: DropdownItem[] =
        [
            { content: 'JavaScript', iconName: 'node-js' },
            { content: 'C#' }];

    languageVersionItems: DropdownItem[] =
        [
            { content: 'Node v18.x' },
            { content: 'Node v17.x' },
        ];

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
        this.selectedLanguage = this.languageItems[0].content;
        this.content = this.completedContent;
    }

    languageChanged(item: DropdownItem): void {
        this.selectedLanguage = item.content;
    }

    public onCodeChange(code: string) {
        this.content = code;
        if (this.tabName === 'Complete solution') {
            this.completedContent = code;
        } else if (this.tabName === 'Initial solution') {
            this.initialContent = code;
        } else if (this.tabName === 'Preloaded') {
            this.preloadedContent = code;
        }
    }

    switchTab(tabName: string): void {
        this.tabName = tabName;
        if (tabName === 'Complete solution') {
            this.content = this.completedContent;
        } else if (tabName === 'Initial solution') {
            this.content = this.initialContent;
        } else if (tabName === 'Preloaded') {
            this.content = this.preloadedContent;
        }
    }
}
