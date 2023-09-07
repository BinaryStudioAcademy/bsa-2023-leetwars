import {
    AfterViewChecked,
    Component,
    ElementRef,
    EventEmitter,
    Input,
    OnChanges,
    OnInit,
    Output,
    Renderer2,
    SimpleChanges,
} from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { fillFormInputs } from '@modules/challenges/challenge-creation/challenge-creation.utils';
import { tabs } from '@modules/challenges/solution-page/solution-page.utils';
import { NavigationTabType } from '@shared/enums/navigation-tab-type';
import { NavigationTab } from '@shared/models/navigation-tab';

@Component({
    selector: 'app-solution-page',
    templateUrl: './solution-page.component.html',
    styleUrls: ['./solution-page.component.sass'],
})
export class SolutionPageComponent implements OnInit, OnChanges {
    @Input() editorLanguage: string;

    @Input() completeSolution: string;

    @Input() initialSolution: string;

    @Input() preloadedCode: string;

    @Input() checkValidation = false;

    @Output() completeSolutionChange = new EventEmitter<string>();

    @Output() initialSolutionChange = new EventEmitter<string>();

    @Output() preloadedCodeChange = new EventEmitter<string>();

    @Output() validationChange = new EventEmitter<boolean>();

    public editorContent: string;

    public tabs = tabs;

    public currentTab = tabs[0];

    public inputForm = new FormGroup({
        completeSolution: new FormControl('', [
            Validators.required,
        ]),
        initialSolution: new FormControl('', [
            Validators.required,
        ]),
    });

    public ngOnInit(): void {
        this.editorContent = this.completeSolution;
    }

    public onCodeChange(code: string) {
        this.editorContent = code;

        switch (this.currentTab.type) {
            case NavigationTabType.Complete:
                this.completeSolution = code;
                this.completeSolutionChange.emit(code);

                this.inputForm.controls.completeSolution.setValue(code);
                this.validationChange.emit(this.inputForm.valid);

                break;
            case NavigationTabType.Initial:
                this.initialSolution = code;
                this.initialSolutionChange.emit(code);

                this.inputForm.controls.initialSolution.setValue(code);
                this.validationChange.emit(this.inputForm.valid);

                break;
            case NavigationTabType.Preloaded:
                this.preloadedCode = code;
                this.preloadedCodeChange.emit(code);
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
                this.editorContent = this.completeSolution;
                break;
            case NavigationTabType.Initial:
                this.editorContent = this.initialSolution;
                break;
            case NavigationTabType.Preloaded:
                this.editorContent = this.preloadedCode;
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
            case NavigationTabType.Complete:
                inputError = this.inputForm.controls.completeSolution.touched && this.inputForm.controls.completeSolution.invalid;
                break;
            case NavigationTabType.Initial:
                inputError = this.inputForm.controls.initialSolution.touched && this.inputForm.controls.initialSolution.invalid;
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
