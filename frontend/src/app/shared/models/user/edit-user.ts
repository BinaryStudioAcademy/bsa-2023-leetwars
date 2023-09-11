import { IChallenge } from '../profile/challenge';

export interface IEditUser {
    uid: string;
    completedChallenge: IChallenge
}
