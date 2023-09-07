import { Entity } from '../common/entity';

export interface Star extends Entity {
    challengeId: number;
    authorId: string;
    isStar: boolean;
}
