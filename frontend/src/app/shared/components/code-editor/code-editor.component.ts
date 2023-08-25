import { Component, Input } from '@angular/core';

interface EditorOptions {
    language: string,
}

@Component({
    selector: 'app-code-editor[language]',
    templateUrl: './code-editor.component.html',
    styleUrls: ['./code-editor.component.sass'],
})
export class CodeEditorComponent {
    @Input() language: string;

    @Input() initSolution: string = '';

    editorOptions: EditorOptions;

    constructor() {
        this.editorOptions = {
            language: this.language,
        };
    }
}
