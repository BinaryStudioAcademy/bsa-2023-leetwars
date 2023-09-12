export interface ICodeRunRequest {
    userId: number;
    challengeVersionId: number;
    isBuilt: boolean;
    language: string;
    userCode: string;
    preloaded?: string;
    tests?: string;
}
