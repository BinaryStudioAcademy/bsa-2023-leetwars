import { IChallengePreview } from '../challenge/challenge-preview';

export interface Star {
    challenge: IChallengePreview;
    authorId: number;
    isStar: boolean;
}
