import { Component, EventEmitter, Input, OnChanges, OnInit, Output, SimpleChanges } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { tabs } from '@modules/challenges/solution-page/solution-page.utils';
import { NavigationTabType } from '@shared/enums/navigation-tab-type';
import { IEditChallengeVersion } from '@shared/models/challenge-version/edit-challenge-version';
import { INewChallengeVersion } from '@shared/models/challenge-version/new-challenge-version';
import { NavigationTab } from '@shared/models/navigation-tab';
import { EditorOptions } from '@shared/models/options/editor-options';

@Component({
    selector: 'app-solution-page',
    templateUrl: './solution-page.component.html',
    styleUrls: ['./solution-page.component.sass'],
})
export class SolutionPageComponent implements OnInit, OnChanges {
    @Input() challengeVersion: INewChallengeVersion | IEditChallengeVersion;

    @Input() editorOptions: EditorOptions;

    @Input() checkValidation = false;

    @Output() validationChange = new EventEmitter<boolean>();

    public editorContent: string;

    public tabs = tabs;

    public currentTab = tabs[0];

    public inputForm = new FormGroup({
        completeSolution: new FormControl('', [Validators.required]),
        initialSolution: new FormControl('', [Validators.required]),
    });

    public ngOnInit(): void {
        this.editorContent = this.challengeVersion.completeSolution;
        console.log(this.challengeVersion);
        console.log(this.editorOptions);
    }

    public onCodeChange(code: string) {
        this.editorContent = code;

        switch (this.currentTab.type) {
            case NavigationTabType.Complete:
                this.challengeVersion.completeSolution = code;

                this.inputForm.controls.completeSolution.setValue(code);
                this.validationChange.emit(this.inputForm.valid);

                break;
            case NavigationTabType.Initial:
                this.challengeVersion.initialSolution = code;

                this.inputForm.controls.initialSolution.setValue(code);
                this.validationChange.emit(this.inputForm.valid);

                break;
            case NavigationTabType.Preloaded:
                this.challengeVersion.preloadedCode = code;
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
            case NavigationTabType.Complete:
                this.editorContent = this.challengeVersion.completeSolution;
                break;
            case NavigationTabType.Initial:
                this.editorContent = this.challengeVersion.initialSolution;
                break;
            case NavigationTabType.Preloaded:
                this.editorContent = this.challengeVersion.preloadedCode;
                break;
            default:
                break;
        }
    }

    ngOnChanges({ checkValidation, challengeVersion }: SimpleChanges): void {
        if (checkValidation && checkValidation.currentValue) {
            this.inputForm.markAllAsTouched();
        }

        if (challengeVersion) {
            this.inputForm.controls.completeSolution.setValue(this.challengeVersion.completeSolution);
            this.inputForm.controls.initialSolution.setValue(this.challengeVersion.initialSolution);
        }

        this.updateEditorContent();
    }

    getTabClass(tab: NavigationTab) {
        let inputError = false;

        switch (tab.type) {
            case NavigationTabType.Complete:
                inputError =
                    this.inputForm.controls.completeSolution.touched &&
                    this.inputForm.controls.completeSolution.invalid;
                break;
            case NavigationTabType.Initial:
                inputError =
                    this.inputForm.controls.initialSolution.touched && this.inputForm.controls.initialSolution.invalid;
                break;
            default:
                break;
        }

        return inputError ? 'input-error' : '';
    }

    editorFocusOut() {
        switch (this.currentTab.type) {
            case NavigationTabType.Complete:
                this.inputForm.controls.completeSolution.markAsTouched();
                break;
            case NavigationTabType.Initial:
                this.inputForm.controls.initialSolution.markAsTouched();
                break;
            default:
                break;
        }
    }
}
