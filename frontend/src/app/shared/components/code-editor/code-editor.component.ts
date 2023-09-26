import { AfterViewInit, Component, EventEmitter, Input, OnChanges, OnInit, Output, SimpleChanges } from '@angular/core';
import { BaseComponent } from '@core/base/base.component';
import { UserService } from '@core/services/user.service';
import { languageNameMap } from '@shared/mappings/language-map';
import { EditorOptions } from '@shared/models/options/editor-options';
import { IUserPreferences } from '@shared/models/user-prefferences/user-preferences';
import { takeUntil } from 'rxjs';

@Component({
    selector: 'app-code-editor[language]',
    templateUrl: './code-editor.component.html',
    styleUrls: ['./code-editor.component.sass'],
})
export class CodeEditorComponent extends BaseComponent implements OnChanges, AfterViewInit, OnInit {
    @Input() language: string;

    @Input() initText: string = '';

    @Output() codeChanged = new EventEmitter<string>();

    @Input() options: EditorOptions;

    editorOptions: EditorOptions;

    userPreferences: IUserPreferences;

    constructor(private userService: UserService) { super(); }

    ngAfterViewInit(): void {
        this.updateEditorOptions();
    }

    public onCodeChange(model: string) {
        this.initText = model;
        this.codeChanged.emit(model);
    }

    ngOnChanges(changes: SimpleChanges): void {
        if (changes['language']) {
            this.editorOptions.language = this.options?.language;
        }
    }

    ngOnInit(): void {
        this.getUserPrefferences();
        this.updateEditorOptions();
    }

    private getUserPrefferences() {
        this.userService
            .getUserPrefferences()
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe({
                next: (preferences) => {
                    if (!preferences) {
                        this.userPreferences = preferences;
                    }
                },
            });
    }

    private mapLanguageName(language?: string): string {
        return language ? languageNameMap.get(language) || language.toLowerCase() : 'No language available';
    }

    private updateEditorOptions(): void {
        this.editorOptions = {
            theme: this.userPreferences?.theme ? this.userPreferences.theme : this.options?.theme,
            language: this.userPreferences?.language ? this.userPreferences?.language : this.mapLanguageName(this.options?.language),
            tabWidth: this.userPreferences?.tabWidth ? this.userPreferences.tabWidth : this.options?.tabWidth,
            fontSize: this.userPreferences?.fontSize ? this.userPreferences.fontSize : this.options?.fontSize,
            wordWrap: this.userPreferences?.wordWrap ? this.userPreferences.wordWrap : this.options?.wordWrap,
            minimap: { enabled: this.options?.minimap?.enabled },
            automaticLayout: this.options?.automaticLayout,
            useShadows: this.options?.useShadows,
            lineNumbers: this.options?.lineNumbers,
        };
    }
}
