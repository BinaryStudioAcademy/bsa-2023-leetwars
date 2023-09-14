import { ITest } from './test';

export interface ITestsOutput {
    isSuccess: boolean;
    failedCount: number;
    passedCount: number;
    overallDuration: string;
    testsWithData: ITest[]
}
