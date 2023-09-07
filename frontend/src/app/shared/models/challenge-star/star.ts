import { ChallengePreview } from '../challenge/challenge-preview';

export interface Star {
    challenge: ChallengePreview;
    authorId: number;
    isStar: boolean;
}
