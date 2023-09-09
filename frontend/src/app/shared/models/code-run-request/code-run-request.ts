export interface CodeRunRequest {
    userId: number;
    challengeVersionId: number;
    isBuilt: boolean;
    language: string;
    userCode: string;
    preloaded: string | null;
    tests: string | null;
}
