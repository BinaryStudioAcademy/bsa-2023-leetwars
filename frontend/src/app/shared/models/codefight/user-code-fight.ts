import { CodeFightStatus } from '../../enums/code-fight-status';

export interface IUserCodeFight {
    senderId: number;
    receiverId: number;
    status: CodeFightStatus;
}
