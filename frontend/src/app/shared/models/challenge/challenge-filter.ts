import { ChallengeProgress } from '@shared/enums/challenge-progress';
import { ChallengeStatus } from '@shared/enums/challenge-status';
import { LanguageLevel } from '@shared/enums/language-level';

export interface IChallengeFilter {
    title: string,
    challengeStatus?: ChallengeStatus,
    languageId?: number,
    tagsIds: number[],
    progress?: ChallengeProgress,
    skillLevel?: LanguageLevel | null,
}
