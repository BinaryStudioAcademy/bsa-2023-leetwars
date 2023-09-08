import { ChallengeLevel } from '../challenge-level/challenge-level';
import { Star } from '../challenge-star/star';
import { ChallengeVersion } from '../challenge-version/challenge-version';
import { AuditEntity } from '../common/audit-entity/audit-entity';
import { Tag } from '../tag/tag';
import { User } from '../user/user';

export interface Challenge extends AuditEntity {
    id: number;
    title: string;
    instructions: string;
    levelId: number;
    level: ChallengeLevel;
    author: User;
    tags: Array<Tag>;
    versions: Array<ChallengeVersion>;
    stars: Array<Star>;
}
