import { IBuildResult } from './build-result';

export interface ICodeRunResults {
    userConnectionId: string;
    challengeVersionId: number;
    language: string;
    buildResults?: IBuildResult | null;
    testRunResults?: string | null;
}
