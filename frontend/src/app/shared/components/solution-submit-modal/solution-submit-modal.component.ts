import { Component, Input } from '@angular/core';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';
import { ColorConstants } from '@shared/constants/color-constants';
import { ICodeAnalysisResult } from '@shared/models/code-analysis/code-analysis-result';
import { ICodeRunResults } from '@shared/models/code-run/code-run-result';

@Component({
    selector: 'app-solution-submit-modal',
    templateUrl: './solution-submit-modal.component.html',
    styleUrls: ['./solution-submit-modal.component.sass'],
})
export class SolutionSubmitModalComponent {
    pieChartActiveColor: string = ColorConstants.pieChartActiveGreedColor;

    @Input() codeRunResults: ICodeRunResults;

    @Input() codeAnalysisResults: ICodeAnalysisResult;

    constructor(public activeModal: NgbActiveModal) {}

    getTotalTestsCount() {
        return this.codeRunResults.testRunResults
            ? this.codeRunResults.testRunResults.passedCount + this.codeRunResults.testRunResults.failedCount
            : 0;
    }

    apply() {
        this.activeModal.close();
    }
}
