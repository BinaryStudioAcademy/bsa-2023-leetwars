import { CategoryType } from '@shared/enums/category-type';
import { IChallengeLevel } from '@shared/models/challenge-level/challenge-level';
import { INewChallengeVersion } from '@shared/models/challenge-version/new-challenge-version';
import { ITag } from '@shared/models/tag/tag';

export interface INewChallenge {
    title: string;
    instructions: string;
    levelId: number;
    level?: IChallengeLevel;
    category: CategoryType;
    tags: Array<ITag>;
    versions: Array<INewChallengeVersion>;
}
