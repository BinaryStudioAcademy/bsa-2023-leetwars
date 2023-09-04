import { Component, Input, OnChanges, OnInit, SimpleChanges } from '@angular/core';

interface EditorOptions {
    language: string;
    theme: string;
}

@Component({
    selector: 'app-code-editor[language]',
    templateUrl: './code-editor.component.html',
    styleUrls: ['./code-editor.component.sass'],
})
export class CodeEditorComponent implements OnChanges, OnInit {
    @Input() language: string;

    @Input() initSolution: string = '';

    editorOptions: EditorOptions;

    ngOnChanges(changes: SimpleChanges): void {
        if (changes['language']) {
            this.updateEditorOptions();
        }
    }

    ngOnInit(): void {
        this.updateEditorOptions();
    }

    private updateEditorOptions(): void {
        this.editorOptions = {
            language: this.language,
            theme: 'vs-dark',
        };
    }
}
