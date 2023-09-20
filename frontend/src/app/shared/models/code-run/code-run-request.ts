export interface ICodeRunRequest {
    userConnectionId: string;
    language: string;
    userCode: string;
    preloaded?: string | null;
    tests?: string | null;
}
