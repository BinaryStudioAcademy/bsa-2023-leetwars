import { Injectable } from '@angular/core';
import { ICodeRunResults } from '@shared/models/code-run/code-run-result';
import { ITestsOutput } from '@shared/models/tests-output/tests-output';

import { ToastrNotificationsService } from './toastr-notifications.service';

@Injectable({
    providedIn: 'root',
})
export class CodeRunService {
    constructor(private toastrService: ToastrNotificationsService) {}

    getCodeRunResults(result: ICodeRunResults) {
        if (result.buildResults?.isSuccess && result.testRunResults) {
            this.toastrService.showSuccess('Code was compiled successfully');
            this.showTestResults(result.testRunResults);
        } else {
            this.toastrService.showError(result.buildResults?.buildMessage as string);
        }
    }

    private showTestResults(testResults: ITestsOutput) {
        if (testResults.isSuccess) {
            this.toastrService.showSuccess(`Tests were successful!\n Tests passed: ${testResults.passedCount}`);
        } else {
            this.toastrService.showError(`Tests failed \n Tests failed: ${testResults.failedCount}
            out of ${testResults.passedCount + testResults.failedCount}`);
        }
    }
}
