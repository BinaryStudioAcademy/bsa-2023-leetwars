import { Component, OnInit } from '@angular/core';
import { CategoryType } from '@shared/enums/category-type';
import { TabType } from '@shared/enums/tab-type';
import { EditorInstance, EditorOption } from 'angular-markdown-editor';
import { MarkdownService } from 'ngx-markdown';

@Component({
    selector: 'app-editor-question',
    templateUrl: './editor-question.component.html',
    styleUrls: ['./editor-question.component.sass'],
})
export class EditorQuestionComponent implements OnInit {
    private bsEditorInstance: EditorInstance;

    public selectedCategory: CategoryType = CategoryType.Fundamentals;

    public selectedTab: TabType = TabType.Description;

    public CategoryType = CategoryType;

    public TabType = TabType;

    public editorOptions: EditorOption;

    public markdownText: string;

    public steps: string[] = ['Question', 'Solutions', 'Testcases'];

    public customInputHeight = '48px';

    public customInputWidth = '100%';

    constructor(private markdownService: MarkdownService) {}

    public ngOnInit() {
        this.editorOptions = {
            parser: (val) => this.markdownService.parse(val.trim()),
            onShow: (edInstance: EditorInstance) => {
                this.bsEditorInstance = edInstance;
            },
        };
    }

    public editMarkDown() {
        this.selectedTab = TabType.Description;
        this.bsEditorInstance.hidePreview();
    }

    public previewMarkDown() {
        this.selectedTab = TabType.Preview;
        this.bsEditorInstance.showPreview();
    }

    public submitQuestion() {
        this.selectedTab = TabType.Help;
    }
}
