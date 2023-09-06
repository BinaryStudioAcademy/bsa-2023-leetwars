import { Component, EventEmitter, Input, OnChanges, OnInit, Output, SimpleChanges } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { fillFormInputs } from '@modules/challenges/challenge-creation/challenge-creation.utils';
import { CategoryType } from '@shared/enums/category-type';
import { TabType } from '@shared/enums/tab-type';
import { ChallengeLevel } from '@shared/models/challenge-level/challenge-level';
import { Tag } from '@shared/models/tag/tag';
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

    @Input() description = '';

    @Input() category: CategoryType;

    @Input() allTags: Tag[];

    @Input() selectedTags: Tag[];

    @Input() allLevels: ChallengeLevel[];

    @Input() selectedLevel?: ChallengeLevel;

    @Input() checkValidation = false;

    @Output() nameChange = new EventEmitter<string>();

    @Output() descriptionChange = new EventEmitter<string>();

    @Output() selectedTagsChange = new EventEmitter<Tag[]>();

    @Output() selectedLevelChange = new EventEmitter<ChallengeLevel | undefined>();

    @Output() categoryChange = new EventEmitter<CategoryType>();

    @Output() validationChange = new EventEmitter<boolean>();

    public allTagsNames: string[] = [];

    public selectedTagsNames: string[] = [];

    public allLevelsNames: string[] = [];

    public selectedLevelName = '';

    inputForm = new FormGroup({
        name: new FormControl(this.name, [
            Validators.required,
        ]),
        description: new FormControl(this.description, [
            Validators.required,
        ]),
        tags: new FormControl(this.selectedTagsNames, [
            Validators.required,
        ]),
        level: new FormControl(this.selectedLevelName, [
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
        this.category = value;
    }

    public onTagsChange(value: string | string[]) {
        if (typeof value === 'string') {
            return;
        }

        const selectedTags = value.map(tagName =>
            this.allTags.find(item => item.name === tagName))
            .filter(item => item !== undefined) as Tag[];

        this.selectedTagsChange.emit(selectedTags);

        this.inputForm.controls.tags.setValue(value);
        this.validationChange.emit(this.inputForm.valid);
    }

    public onLevelChange(value: string | string[]) {
        if (typeof value !== 'string') {
            return;
        }

        const selectedLevel = this.allLevels.find(item => item.name === value);

        this.selectedLevelChange.emit(selectedLevel);

        this.inputForm.controls.level.setValue(selectedLevel?.name ?? '');
        this.validationChange.emit(this.inputForm.valid);
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
        if (changes['allTags']) {
            this.allTagsNames = this.allTags.map(t => t.name);
        }
        if (changes['selectedTags']) {
            this.selectedTagsNames = this.selectedTags.map(t => t.name);
            this.inputForm.controls.tags.setValue(this.selectedTagsNames);
        }
        if (changes['allLevels']) {
            this.allLevelsNames = this.allLevels.map(t => t.name);
        }
        if (changes['selectedLevel']) {
            this.selectedLevelName = this.selectedLevel?.name ?? '';
            this.inputForm.controls.level.setValue(this.selectedLevelName);
        }
        fillFormInputs(this.inputForm, changes);
    }
}
