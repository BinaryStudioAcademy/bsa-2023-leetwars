export interface CodeRunResults {
    userId: number;
    challengeVersionId: number;
    isBuilt: boolean;
    language: string;
    buildErrorOutput: string | null;
    testRunResults: string | null;
}
