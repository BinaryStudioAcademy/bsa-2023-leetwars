import { Component, EventEmitter, Input, OnChanges, OnInit, Output, SimpleChanges } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { fillFormInputs } from '@modules/challenges/challenge-creation/challenge-creation.utils';
import { CategoryType } from '@shared/enums/category-type';
import { TabType } from '@shared/enums/tab-type';
import { getErrorMessage } from '@shared/utils/validation/validation-helper';
import { EditorInstance, EditorOption } from 'angular-markdown-editor';
import { MarkdownService } from 'ngx-markdown';

@Component({
    selector: 'app-editor-question',
    templateUrl: './editor-question.component.html',
    styleUrls: ['./editor-question.component.sass'],
})
export class EditorQuestionComponent implements OnInit, OnChanges {
    @Input() name = '';

    @Output() nameChange = new EventEmitter<string>();

    @Input() description = '';

    @Output() descriptionChange = new EventEmitter<string>();

    @Input() category: CategoryType;

    @Output() categoryChange = new EventEmitter<CategoryType>();

    @Input() checkValidation = false;

    @Output() validationChange = new EventEmitter<boolean>();

    inputForm = new FormGroup({
        name: new FormControl(this.name, [
            Validators.required,
        ]),
        description: new FormControl(this.description, [
            Validators.required,
        ]),
    });

    private bsEditorInstance: EditorInstance;

    public selectedTab: TabType = TabType.Description;

    public CategoryType = CategoryType;

    public TabType = TabType;

    public editorOptions: EditorOption;

    public customInputHeight = '48px';

    public customInputWidth = '100%';

    constructor(private markdownService: MarkdownService) {}

    public ngOnInit() {
        this.editorOptions = {
            parser: (val) => this.markdownService.parse(val.trim()),
            onChange: (e) => this.onDescriptionChange(e.getContent()),
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

    public onNameChange(value: string) {
        this.nameChange.emit(value);

        this.inputForm.controls.name.setValue(value);
        this.validationChange.emit(this.inputForm.valid);
    }

    public onDescriptionChange(value: string) {
        this.descriptionChange.emit(value);

        this.inputForm.controls.description.setValue(value);
        this.validationChange.emit(this.inputForm.valid);
    }

    public onCategoryChange(value: CategoryType) {
        this.categoryChange.emit(value);
    }

    public getErrorMessage(formControlName: string) {
        return getErrorMessage(formControlName, this.inputForm);
    }

    ngOnChanges(changes: SimpleChanges): void {
        if (changes['checkValidation']) {
            if (this.checkValidation) {
                this.inputForm.markAllAsTouched();
            }
        }
        fillFormInputs(this.inputForm, changes);
    }
}
