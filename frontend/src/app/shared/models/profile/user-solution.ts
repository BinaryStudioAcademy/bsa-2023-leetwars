import { AuditEntity } from '@shared/models/common/audit-entity/audit-entity';

import { Entity } from '../common/entity';

export interface UserSolution extends AuditEntity, Entity {
    challengeVersionId: number;
    code: string;
    output: string;
    submittedAt?: Date;
}
