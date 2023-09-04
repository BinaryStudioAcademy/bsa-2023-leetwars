import { ChallengeLevel } from '../challenge-level/challenge-level';
import { ChallengeVersion } from '../challenge-version/challenge-version';
import { AuditEntity } from '../common/audit-entity/audit-entity';
import { Entity } from '../common/entity';
import { Tag } from '../tag/tag';
import { User } from '../user';

export interface Challenge extends AuditEntity, Entity {
    title: string;
    instructions: string;
    levelId: number;
    level: ChallengeLevel;
    author: User;
    tags: Array<Tag>;
    versions: Array<ChallengeVersion>;
}
