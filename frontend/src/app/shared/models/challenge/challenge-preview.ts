import { Language } from '@shared/models/language/language';
import { Tag } from '@shared/models/tag/tag';
import {ChallengeStatus} from "@shared/enums/challenge-status";

export interface ChallengePreview {
    authorName: string,
    levelName: string,
    title: string,
    instructions: string,
    tags: Tag[],
    languages: Language[],
    status: ChallengeStatus,
}
