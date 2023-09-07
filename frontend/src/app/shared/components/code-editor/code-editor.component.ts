import { Component, EventEmitter, Input, OnChanges, OnInit, Output, SimpleChanges } from '@angular/core';

interface EditorOptions {
    language: string;
    theme: string;
    minimap: {
        enabled: boolean;
    };
    automaticLayout: boolean;
    useShadows: boolean;
    wordWrap: string;
    lineNumbers: string;
}

@Component({
    selector: 'app-code-editor[language]',
    templateUrl: './code-editor.component.html',
    styleUrls: ['./code-editor.component.sass'],
})
export class CodeEditorComponent implements OnChanges, OnInit {
    languageNameMap: Map<string, string> = new Map<string, string>([['C#', 'csharp']]);

    @Input() language: string;

    @Input() initSolution: string = '';

    @Output() codeChanged = new EventEmitter<string>();

    editorOptions: EditorOptions;

    public onCodeChange(model: string) {
        this.initSolution = model;
        this.codeChanged.emit(model);
    }

    ngOnChanges(changes: SimpleChanges): void {
        if (changes['language']) {
            this.updateEditorOptions();
        }
    }

    ngOnInit(): void {
        this.updateEditorOptions();
    }

    private mapLanguageName(language: string): string {
        return this.languageNameMap.get(language) || language.toLowerCase();
    }

    private updateEditorOptions(): void {
        this.editorOptions = {
            theme: 'custom-theme',
            language: this.mapLanguageName(this.language),
            minimap: { enabled: false },
            automaticLayout: true,
            useShadows: false,
            wordWrap: 'on',
            lineNumbers: 'on',
        };
    }
}
