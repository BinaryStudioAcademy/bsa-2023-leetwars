import { ChallengeStatus } from '@shared/enums/challenge-status';
import { Language } from '@shared/models/language/language';
import { Tag } from '@shared/models/tag/tag';

export interface ChallengePreview {
    authorName: string;
    levelName: string;
    title: string;
    instructions: string;
    tags: Tag[];
    languages: Language[];
    status: ChallengeStatus;
    isStarry: boolean;
    starsAmount: number;
}
