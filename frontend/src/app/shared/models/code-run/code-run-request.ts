export interface ICodeRunRequest {
    userConnectionId: string;
    challengeVersionId: number;
    language: string;
    userCode: string;
    preloaded?: string | null;
    tests?: string | null;
}
