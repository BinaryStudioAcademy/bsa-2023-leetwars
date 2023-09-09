export interface Test {
    testName: string;
    isSuccess: boolean;
    errorMessage: string | null;
    duration: string;
}
