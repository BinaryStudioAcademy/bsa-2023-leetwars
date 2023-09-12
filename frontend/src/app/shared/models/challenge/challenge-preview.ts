import { ChallengeStatus } from '@shared/enums/challenge-status';
import { ILanguage } from '@shared/models/language/language';
import { ITag } from '@shared/models/tag/tag';

import { Entity } from '../common/entity';

export interface IChallengePreview extends Entity<number> {
    authorName: string;
    levelName: string;
    title: string;
    instructions: string;
    tags: ITag[];
    languages: ILanguage[];
    status: ChallengeStatus;
    isStarry: boolean;
    starsAmount: number;
}
