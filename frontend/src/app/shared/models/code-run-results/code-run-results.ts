import { ITestsOutput } from '../tests-output/tests-output';

export interface ICodeRunResults {
    userId: number;
    challengeVersionId: number;
    isBuilt: boolean;
    language: string;
    buildErrorOutput?: string;
    testRunResults?: ITestsOutput;
}
