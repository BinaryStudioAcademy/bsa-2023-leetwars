import { INotificationModel } from '../notifications/notifications';

export interface ICodeFightStart {
    senderId: string;
    receiverId: string;
    challengeId: number;
    notification: INotificationModel;
}
