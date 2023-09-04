import { ChallengeLevel } from '../challenge-level/challenge-level';
import { ChallengeVersion } from '../challenge-version/challenge-version';
import { AuditEntity } from '../common/audit-entity/audit-entity';
import { Tag } from '../tag/tag';
import { User } from '../user/user';

export interface Challenge extends AuditEntity {
    title: string;
    instructions: string;
    levelId: number;
    level: ChallengeLevel;
    author: User;
    tags: Array<Tag>;
    versions: Array<ChallengeVersion>;
}
