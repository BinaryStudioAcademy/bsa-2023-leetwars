import { IChallengePreview } from '../challenge/challenge-preview';

export interface IStar {
    challenge: IChallengePreview;
    authorId: number;
    isStar: boolean;
}
