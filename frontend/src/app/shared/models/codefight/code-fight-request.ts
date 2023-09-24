import { INotificationModel } from '../notifications/notifications';

export interface ICodeFightRequest {
    senderId: string;
    receiverId: string;
    challengeId: number;
    notification: INotificationModel;
}
