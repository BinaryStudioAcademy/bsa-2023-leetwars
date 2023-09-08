import { Entity } from '@shared/models/common/entity';

export interface ITag extends Entity<number> {
    name: string;
}
