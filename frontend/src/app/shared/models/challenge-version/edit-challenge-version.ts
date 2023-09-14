export interface IEditChallengeVersion {
    id: number;
    createdAt: string;
    languageId: number;
    initialSolution: string;
    completeSolution: string;
    preloadedCode: string;
    testCases: string;
    exampleTestCases: string;
}
