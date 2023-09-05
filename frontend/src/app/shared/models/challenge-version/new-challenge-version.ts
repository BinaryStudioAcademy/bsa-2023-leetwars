import { Test } from '../test/test';

export interface NewChallengeVersion {
    languageId: number;
    initialSolution: string;
    completeSolution: string;
    tests: Array<Test>;
}
