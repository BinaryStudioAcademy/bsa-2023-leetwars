import {
    Component,
    ElementRef,
    EventEmitter,
    HostListener,
    Input,
    OnChanges,
    OnInit,
    Output,
    SimpleChanges,
    ViewChild,
} from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { getNewChallengeVersion } from '@modules/challenges/challenge-creation/challenge-creation.utils';
import { NavigationTabType } from '@shared/enums/navigation-tab-type';
import { IEditChallengeVersion } from '@shared/models/challenge-version/edit-challenge-version';
import { INewChallengeVersion } from '@shared/models/challenge-version/new-challenge-version';
import { NavigationTab } from '@shared/models/navigation-tab';
import { EditorOptions } from '@shared/models/options/editor-options';

import { tabs } from './challenges-test-page.utils';

@Component({
    selector: 'app-challenges-test-page',
    templateUrl: './challenges-test-page.component.html',
    styleUrls: ['./challenges-test-page.component.sass'],
})
export class ChallengesTestPageComponent implements OnInit, OnChanges {
    @Input() challengeVersion: INewChallengeVersion | IEditChallengeVersion = getNewChallengeVersion();

    @Input() editorOptions: EditorOptions;

    @Input() checkValidation = false;

    @Output() validationChange = new EventEmitter<boolean>();

    @ViewChild('editorContainer') editorContainer: ElementRef;

    editorContent: string;

    tabs = tabs;

    currentTab = tabs[0];

    isMaximized: boolean = false;

    inputForm = new FormGroup({
        testCases: new FormControl('', [Validators.required]),
        exampleTestCases: new FormControl('', [Validators.required]),
    });

    ngOnInit(): void {
        this.editorContent = this.challengeVersion.testCases;
    }

    ngOnChanges({ checkValidation, challengeVersion }: SimpleChanges): void {
        if (checkValidation && checkValidation.currentValue) {
            this.inputForm.markAllAsTouched();
        }

        if (challengeVersion) {
            this.inputForm.controls.testCases.setValue(this.challengeVersion.testCases);
            this.inputForm.controls.exampleTestCases.setValue(this.challengeVersion.exampleTestCases);
        }

        this.updateEditorContent();
    }

    onCodeChange(code: string) {
        this.editorContent = code;

        switch (this.currentTab.type) {
            case NavigationTabType.TestCases:
                this.challengeVersion.testCases = code;
                this.inputForm.controls.testCases.setValue(code);

                break;
            case NavigationTabType.ExampleTestCases:
                this.challengeVersion.exampleTestCases = code;
                this.inputForm.controls.exampleTestCases.setValue(code);

                break;
            default:
                break;
        }
        this.validationChange.emit(this.inputForm.valid);
    }

    switchTab(tab: NavigationTab): void {
        this.currentTab = tab;
        this.updateEditorContent();
    }

    updateEditorContent() {
        switch (this.currentTab.type) {
            case NavigationTabType.TestCases:
                this.editorContent = this.challengeVersion.testCases;
                break;
            case NavigationTabType.ExampleTestCases:
                this.editorContent = this.challengeVersion.exampleTestCases;
                break;
            default:
                break;
        }
    }

    getTabClass(tab: NavigationTab) {
        let inputError = false;

        switch (tab.type) {
            case NavigationTabType.TestCases:
                inputError = this.inputForm.controls.testCases.touched && this.inputForm.controls.testCases.invalid;
                break;
            case NavigationTabType.ExampleTestCases:
                inputError =
                    this.inputForm.controls.exampleTestCases.touched &&
                    this.inputForm.controls.exampleTestCases.invalid;
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

    @HostListener('fullscreenchange')
    onExitFullScreen() {
        if (!document.fullscreenElement) {
            this.isMaximized = false;
        }
    }

    toggleMaximize(element: HTMLDivElement) {
        this.isMaximized = !this.isMaximized;
        if (this.isMaximized) {
            element.requestFullscreen();
        } else {
            document.exitFullscreen();
        }
    }
}
