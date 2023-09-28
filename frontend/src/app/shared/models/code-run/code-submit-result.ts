import { ICodeAnalysisResult } from '../code-analysis/code-analysis-result';

import { ICodeRunResults } from './code-run-result';

export interface ICodeSubmitResult {
    codeRunResult: ICodeRunResults;
    codeAnalysisResult: ICodeAnalysisResult;
}
