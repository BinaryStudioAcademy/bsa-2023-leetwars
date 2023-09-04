import { Entity } from '@shared/models/common/entity';

export interface AuditEntity extends Entity {
    createdAt: Date,
    createdBy?: number,
}
