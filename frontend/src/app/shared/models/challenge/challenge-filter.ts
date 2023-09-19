import { ChallengeProgress } from '@shared/enums/challenge-progress';
import { ChallengeStatus } from '@shared/enums/challenge-status';
import { SkillLevel } from '@shared/enums/skill-level';

export interface IChallengeFilter {
    title: string,
    challengeStatus?: ChallengeStatus,
    languageId?: number,
    tagsIds: number[],
    progress?: ChallengeProgress,
    difficultyLevel?: SkillLevel | null,
}
