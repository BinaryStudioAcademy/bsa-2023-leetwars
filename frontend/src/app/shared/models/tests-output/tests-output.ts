import { Test } from './test';

export interface TestsOutput {
    isSuccess: boolean;
    failedCount: number;
    passedCount: number;
    overallDuration: string;
    testsWithData: Test[]
}
