import { Entity } from '@shared/models/common/entity';

export interface AuditEntity<T> extends Entity<T> {
    createdAt: Date,
    createdBy?: number,
}
