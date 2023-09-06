import { Component, EventEmitter, Input, OnChanges, OnInit, Output, SimpleChanges } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { fillFormInputs } from '@modules/challenges/challenge-creation/challenge-creation.utils';
import { NavigationTabType } from '@shared/enums/navigation-tab-type';
import { NavigationTab } from '@shared/models/navigation-tab';

import { tabs } from './challenges-test-page.utils';

@Component({
    selector: 'app-challenges-test-page',
    templateUrl: './challenges-test-page.component.html',
    styleUrls: ['./challenges-test-page.component.sass'],
})
export class ChallengesTestPageComponent implements OnInit, OnChanges {
    @Input() editorLanguage: string;

    @Input() testCases: string;

    @Input() exampleTestCases: string;

    @Input() checkValidation = false;

    @Output() testCasesChange = new EventEmitter<string>();

    @Output() exampleTestCasesChange = new EventEmitter<string>();

    @Output() validationChange = new EventEmitter<boolean>();

    public editorContent: string;

    public tabs = tabs;

    public currentTab = tabs[0];

    public isMaximized: boolean = false;

    public inputForm = new FormGroup({
        testCases: new FormControl('', [
            Validators.required,
        ]),
        exampleTestCases: new FormControl('', [
            Validators.required,
        ]),
    });

    ngOnInit(): void {
        this.editorContent = this.testCases;
    }

    public onCodeChange(code: string) {
        this.editorContent = code;

        switch (this.currentTab.type) {
            case NavigationTabType.TestCases:
                this.testCases = code;
                this.testCasesChange.emit(code);

                this.inputForm.controls.testCases.setValue(code);
                this.validationChange.emit(this.inputForm.valid);

                break;
            case NavigationTabType.ExampleTestCases:
                this.exampleTestCases = code;
                this.exampleTestCasesChange.emit(code);

                this.inputForm.controls.exampleTestCases.setValue(code);
                this.validationChange.emit(this.inputForm.valid);

                break;
            default:
                break;
        }
    }

    switchTab(tab: NavigationTab): void {
        this.currentTab = tab;
        this.updateEditorContent();
    }

    public updateEditorContent() {
        switch (this.currentTab.type) {
            case NavigationTabType.TestCases:
                this.editorContent = this.testCases;
                break;
            case NavigationTabType.ExampleTestCases:
                this.editorContent = this.exampleTestCases;
                break;
            default:
                break;
        }
    }

    ngOnChanges(changes: SimpleChanges): void {
        if (changes['checkValidation']) {
            if (this.checkValidation) {
                this.inputForm.markAllAsTouched();
            }
        }
        fillFormInputs(this.inputForm, changes);
        this.updateEditorContent();
    }

    getTabClass(tab: NavigationTab) {
        let inputError = false;

        switch (tab.type) {
            case NavigationTabType.TestCases:
                inputError = this.inputForm.controls.testCases.touched && this.inputForm.controls.testCases.invalid;
                break;
            case NavigationTabType.ExampleTestCases:
                inputError = this.inputForm.controls.exampleTestCases.touched && this.inputForm.controls.exampleTestCases.invalid;
                break;
            default:
                break;
        }

        return inputError ? 'input-error' : '';
    }

    editorFocusOut() {
        switch (this.currentTab.type) {
            case NavigationTabType.TestCases:
                this.inputForm.controls.testCases.markAsTouched();
                break;
            case NavigationTabType.ExampleTestCases:
                this.inputForm.controls.exampleTestCases.markAsTouched();
                break;
            default:
                break;
        }
    }

    toggleMaximize() {
        this.isMaximized = !this.isMaximized;
    }
}
