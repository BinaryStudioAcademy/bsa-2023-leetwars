import { CategoryType } from '@shared/enums/category-type';
import { IChallengeLevel } from '@shared/models/challenge-level/challenge-level';
import { IEditChallengeVersion } from '@shared/models/challenge-version/edit-challenge-version';
import { ITag } from '@shared/models/tag/tag';

import { AuditEntity } from '../common/audit-entity/audit-entity';

export interface IEditChallenge extends AuditEntity<number> {
    title: string;
    instructions: string;
    levelId: number;
    level?: IChallengeLevel;
    category: CategoryType;
    tags: Array<ITag>;
    versions: Array<IEditChallengeVersion>;
}
