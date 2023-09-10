import { BuildResult } from './build-result';

export interface CodeRunResults {
    userId: number;
    challengeVersionId: number;
    language: string;
    buildResults?: BuildResult | null;
    testRunResults?: string | null;
}
