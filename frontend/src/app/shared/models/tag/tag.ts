import { Entity } from '@shared/models/common/entity';

export interface Tag extends Entity<number> {
    name: string,
}
