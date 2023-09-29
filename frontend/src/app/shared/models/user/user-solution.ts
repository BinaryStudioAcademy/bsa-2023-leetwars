import { AuditEntity } from '../common/audit-entity/audit-entity';

export interface IUserSolution extends AuditEntity<number> {
    challengeVersionId: number;
    code: string;
    output: string;
    submittedAt: Date;
}
