import { ITestsOutput } from '../tests-output/tests-output';

import { IBuildResult } from './build-result';

export interface ICodeRunResults {
    userConnectionId: string;
    challengeVersionId: number;
    language: string;
    buildResults?: IBuildResult | null;
    testRunResults?: ITestsOutput | null;
}
