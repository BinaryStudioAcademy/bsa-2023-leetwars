import { AuditEntity } from '../common/audit-entity/audit-entity';


export interface Test extends AuditEntity<number> {
    challengeVersionId: number;
    code: string;
    isPublic: boolean;
}
