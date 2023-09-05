import { CategoryType } from '@shared/enums/category-type';
import { NewChallengeVersion } from '@shared/models/challenge-version/new-challenge-version';
import { Tag } from '@shared/models/tag/tag';

export interface NewChallenge {
    title: string;
    instructions: string;
    category: CategoryType;
    tags: Array<Tag>;
    versions: Array<NewChallengeVersion>;
}
