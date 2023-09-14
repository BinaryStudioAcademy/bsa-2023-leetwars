export interface ICodeRunRequest {
    userConnectionId: string;
    userId: number;
    challengeVersionId: number;
    language: string;
    userCode: string;
    preloaded?: string | null;
    tests?: string | null;
}
