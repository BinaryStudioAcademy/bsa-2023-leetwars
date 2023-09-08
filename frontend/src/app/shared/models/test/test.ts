import { AuditEntity } from '../common/audit-entity/audit-entity';

export interface ITest extends AuditEntity<number> {
    challengeVersionId: number;
    code: string;
    isPublic: boolean;
}
