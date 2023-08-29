import { Component, OnInit } from '@angular/core';
import { CategoryType } from '@shared/enums/category-type';
import { TabType } from '@shared/enums/tab-type';
import { EditorOption } from 'angular-markdown-editor';
import { MarkdownService } from 'ngx-markdown';

@Component({
    selector: 'app-editor-question',
    templateUrl: './editor-question.component.html',
    styleUrls: ['./editor-question.component.sass'],
})
export class EditorQuestionComponent implements OnInit {
    public selectedCategory: CategoryType = CategoryType.Fundamentals;

    public selectedTab: TabType = TabType.Description;

    public CategoryType = CategoryType;

    public TabType = TabType;

    public editorOptions: EditorOption;

    public markdownText: string;

    constructor(private markdownService: MarkdownService) {}

    public ngOnInit() {
        this.editorOptions = {
            iconlibrary: 'fa',
            hiddenButtons: ['bootstrap-markdown-cmdBold'],
            parser: (val) => this.markdownService.parse(val.trim()),
        };
    }

    public editMarkDown() {
        this.selectedTab = TabType.Description;

        //add logic
    }

    public previewMarkDown() {
        this.selectedTab = TabType.Preview;

        //add logic
    }
}
