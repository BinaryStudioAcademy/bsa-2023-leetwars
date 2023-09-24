import { ICodeFightChallengeSettings } from './code-fight-challenge-settings';

export interface ICodeFightRequest {
    senderId: number;
    receiverId: number;
    challengeSettings: ICodeFightChallengeSettings;
}
