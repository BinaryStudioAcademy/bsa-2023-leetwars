import { ChallengeStatus } from '@shared/enums/challenge-status';
import { ILanguage } from '@shared/models/language/language';
import { ITag } from '@shared/models/tag/tag';

export interface IChallengePreview {
    authorName: string,
    levelName: string,
    title: string,
    instructions: string,
    tags: ITag[],
    languages: ILanguage[],
    status: ChallengeStatus,
    isStarry: boolean;
    starsAmount: number;
}
