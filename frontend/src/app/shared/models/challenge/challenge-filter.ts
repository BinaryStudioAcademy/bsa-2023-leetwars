import { ChallengeProgress } from '@shared/enums/challenge-progress';
import { ChallengeStatus } from '@shared/enums/challenge-status';
import { DifficultyLevel } from '@shared/enums/difficulty-level';

export interface IChallengeFilter {
    title: string,
    challengeStatus?: ChallengeStatus,
    languageId?: number,
    tagsIds: number[],
    progress?: ChallengeProgress,
    difficultyLevel?: DifficultyLevel,
}
