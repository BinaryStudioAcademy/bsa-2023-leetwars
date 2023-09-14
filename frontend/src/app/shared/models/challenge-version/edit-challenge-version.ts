import { AuditEntity } from '../common/audit-entity/audit-entity';

export interface IEditChallengeVersion extends AuditEntity<number> {
    languageId: number;
    initialSolution: string;
    completeSolution: string;
    preloadedCode: string;
    testCases: string;
    exampleTestCases: string;
}
