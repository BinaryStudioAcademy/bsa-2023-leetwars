import { Entity } from '../common/entity';
import { User } from '../user/user';

export interface Star extends Entity {
    challengeId: number;
    authorId: string;
    author: User;
}
