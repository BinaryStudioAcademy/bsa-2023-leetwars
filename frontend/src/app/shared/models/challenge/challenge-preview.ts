import { ChallengeStatus } from '@shared/enums/challenge-status';

import { Entity } from '../common/entity';
import { ILanguage } from '../language/language';
import { ITag } from '../tag/tag';

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
