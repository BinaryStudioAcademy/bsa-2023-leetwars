import { AfterViewInit, Component, EventEmitter, Input, OnChanges, OnInit, Output, SimpleChanges } from '@angular/core';
import { EditorOptions } from '@shared/models/options/editor-options';

@Component({
    selector: 'app-code-editor[language]',
    templateUrl: './code-editor.component.html',
    styleUrls: ['./code-editor.component.sass'],
})
export class CodeEditorComponent implements OnChanges, AfterViewInit, OnInit {
    @Input() language: string;

    @Input() initText: string = '';

    @Output() codeChanged = new EventEmitter<string>();

    @Input() options: EditorOptions;

    editorOptions: EditorOptions;

    ngAfterViewInit(): void {
        this.updateEditorOptions();
    }

    public onCodeChange(model: string) {
        this.initText = model;
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

    private updateEditorOptions(): void {
        this.editorOptions = {
            theme: this.options?.theme,
            language: this.options?.language,
            minimap: { isEnabled: this.options?.minimap?.isEnabled },
            hasAutomaticLayout: this.options?.hasAutomaticLayout,
            hasShadows: this.options?.hasShadows,
            wordWrap: this.options?.wordWrap,
            lineNumbers: this.options?.lineNumbers,
        };
    }
}
