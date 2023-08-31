import { AuditEntity } from '@shared/models/common/audit-entity/audit-entity';

export interface UserSolution extends AuditEntity {
    challengeVersionId: number;
    code: string;
    output: string;
    submittedAt?: Date;
}
