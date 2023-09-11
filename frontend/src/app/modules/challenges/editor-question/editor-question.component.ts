import { Component, EventEmitter, Input, OnChanges, OnInit, Output, SimpleChanges } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { getNewChallenge } from '@modules/challenges/challenge-creation/challenge-creation.utils';
import { CategoryType } from '@shared/enums/category-type';
import { TabType } from '@shared/enums/tab-type';
import { NewChallenge } from '@shared/models/challenge/new-challenge';
import { IChallengeLevel } from '@shared/models/challenge-level/challenge-level';
import { ITag } from '@shared/models/tag/tag';
import { getErrorMessage } from '@shared/utils/validation/validation-helper';
import { EditorInstance, EditorOption } from 'angular-markdown-editor';
import { MarkdownService } from 'ngx-markdown';

@Component({
    selector: 'app-editor-question',
    templateUrl: './editor-question.component.html',
    styleUrls: ['./editor-question.component.sass'],
})
export class EditorQuestionComponent implements OnInit, OnChanges {
    @Input() challenge: NewChallenge = getNewChallenge();

    @Input() allTags: ITag[];

    @Input() allLevels: IChallengeLevel[];

    @Input() checkValidation = false;

    @Output() validationChange = new EventEmitter<boolean>();

    public allTagsNames: string[] = [];

    public selectedTagsNames: string[] = [];

    public allLevelsNames: string[] = [];

    public selectedLevelName = '';

    inputForm = new FormGroup({
        name: new FormControl(this.challenge.title, [
            Validators.required,
        ]),
        description: new FormControl(this.challenge.instructions, [
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

    constructor(private markdownService: MarkdownService) {
    }

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
        this.challenge.title = value;

        this.inputForm.controls.name.setValue(value);
        this.validationChange.emit(this.inputForm.valid);
    }

    public onDescriptionChange(value: string) {
        this.challenge.instructions = value;

        this.inputForm.controls.description.setValue(value);
        this.validationChange.emit(this.inputForm.valid);
    }

    public onCategoryChange(value: CategoryType) {
        this.challenge.category = value;
    }

    public onTagsChange(value: string | string[]) {
        if (typeof value === 'string') {
            return;
        }

        this.challenge.tags = this.allTags.filter(tag => value.includes(tag.name));

        this.inputForm.controls.tags.setValue(value);
        this.validationChange.emit(this.inputForm.valid);
    }

    public onLevelChange(value: string | string[]) {
        if (typeof value !== 'string') {
            return;
        }

        this.challenge.level = this.allLevels.find(item => item.name === value);

        this.inputForm.controls.level.setValue(this.challenge.level?.name ?? '');
        this.validationChange.emit(this.inputForm.valid);
    }

    public getErrorMessage(formControlName: string) {
        return getErrorMessage(formControlName, this.inputForm);
    }

    ngOnChanges({ checkValidation, challenge, allTags, allLevels }: SimpleChanges): void {
        if (checkValidation && checkValidation.currentValue) {
            this.inputForm.markAllAsTouched();
        }
        if (allTags) {
            this.allTagsNames = this.allTags.map(t => t.name);
        }
        if (allLevels) {
            this.allLevelsNames = this.allLevels.map(t => t.name);
        }
        if (challenge) {
            this.selectedTagsNames = this.challenge.tags.map(t => t.name);
            this.inputForm.controls.tags.setValue(this.selectedTagsNames);

            this.selectedLevelName = this.challenge.level?.name ?? '';
            this.inputForm.controls.level.setValue(this.selectedLevelName);

            this.inputForm.controls.name.setValue(this.challenge.title);
            this.inputForm.controls.description.setValue(this.challenge.instructions);
        }
    }
}
