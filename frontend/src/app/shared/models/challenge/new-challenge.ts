import { CategoryType } from '@shared/enums/category-type';
import { ChallengeLevel } from '@shared/models/challenge-level/challenge-level';
import { NewChallengeVersion } from '@shared/models/challenge-version/new-challenge-version';
import { Tag } from '@shared/models/tag/tag';

export interface NewChallenge {
    title: string;
    instructions: string;
    levelId: number;
    level: ChallengeLevel;
    category: CategoryType;
    tags: Array<Tag>;
    versions: Array<NewChallengeVersion>;
}
