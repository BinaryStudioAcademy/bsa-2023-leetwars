import { IChallengeLevel } from '../challenge-level/challenge-level';
import { Star } from '../challenge-star/star';
import { IChallengeVersion } from '../challenge-version/challenge-version';
import { AuditEntity } from '../common/audit-entity/audit-entity';
import { ITag } from '../tag/tag';
import { IUser } from '../user/user';

export interface IChallenge extends AuditEntity<number> {
    id: number;
    title: string;
    instructions: string;
    levelId: number;
    level: IChallengeLevel;
    author: IUser;
    tags: Array<ITag>;
    versions: Array<IChallengeVersion>;
    stars: Array<Star>;
}

