import { AuditEntity } from '../common/audit-entity/audit-entity';
import { Entity } from '../common/entity';

export interface Test extends AuditEntity, Entity {
    challengeVersionId: number;
    code: string;
    isPublic: boolean;
}
