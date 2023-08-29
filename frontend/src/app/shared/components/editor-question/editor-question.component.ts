import { Component, OnInit } from '@angular/core';
import { EditorInstance, EditorOption } from 'angular-markdown-editor';
import { MarkdownService } from 'ngx-markdown';

@Component({
    selector: 'app-editor-question',
    templateUrl: './editor-question.component.html',
    styleUrls: ['./editor-question.component.sass'],
})
export class EditorQuestionComponent implements OnInit {
    constructor(private markdownService: MarkdownService) {}

    bsEditorInstance: EditorInstance;

    public editorOptions: EditorOption;

    public markdownText: string;

    ngOnInit() {
        this.editorOptions = {
            iconlibrary: 'fa',
            onShow: (e: EditorInstance) => (this.bsEditorInstance = e),
            parser: (val) => this.markdownService.parse(val.trim()),
            onPreview: (e) => {
                console.log(e);
                console.log(this.markdownText);
            },
        };
    }

    showFullScreen() {
        this.bsEditorInstance.setFullscreen(true);
    }
}
