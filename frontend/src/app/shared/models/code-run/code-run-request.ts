export interface ICodeRunRequest {
    userConnectionId: string;
    language: string;
    userCode: string;
    isSubmitRequest: boolean;
    preloaded?: string | null;
    tests?: string | null;
}
