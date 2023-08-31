import { Component, EventEmitter, Input, Output } from '@angular/core';

interface EditorOptions {
    language: string,
    theme: string,
}

@Component({
    selector: 'app-code-editor[language]',
    templateUrl: './code-editor.component.html',
    styleUrls: ['./code-editor.component.sass'],
})
export class CodeEditorComponent {
    @Input() language: string;

    @Input() initSolution: string = '';

    @Output() codeChanged = new EventEmitter<string>();

    editorOptions: EditorOptions;

    public onCodeChange(model: string) {
        this.initSolution = model;
        this.codeChanged.emit(model);
    }

    constructor() {
        this.editorOptions = {
            language: this.language,
            theme: 'vs-dark',
        };
    }
}
