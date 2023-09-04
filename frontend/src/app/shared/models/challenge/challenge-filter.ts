import { ChallengeProgress } from '@shared/enums/challenge-progress';
import { ChallengeStatus } from '@shared/enums/challenge-status';

export interface ChallengeFilter {
    title: string,
    challengeStatus?: ChallengeStatus,
    languageId?: number,
    tagsIds: number[],
    progress?: ChallengeProgress,
}
