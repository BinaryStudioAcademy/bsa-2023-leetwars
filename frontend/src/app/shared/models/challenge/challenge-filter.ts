import {ChallengeStatus} from "@shared/enums/challenge-status";
import {ChallengeProgress} from "@shared/enums/challenge-progress";

export interface ChallengeFilter {
    title: string,
    challengeStatus?: ChallengeStatus,
    languageId?: number,
    tagsIds: number[],
    progress?: ChallengeProgress,
}
