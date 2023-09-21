import { ICodeFightChallengeSettings } from '../challenge/fight-challenge-settings';

export interface ICodeFightRequest {
    senderId: number;
    receiverId: number;
    challengeSettings: ICodeFightChallengeSettings;
}
