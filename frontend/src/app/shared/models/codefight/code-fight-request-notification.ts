import { INotificationModel } from '../notifications/notifications';

export interface ICodeFightRequestNotification {
    senderId: number;
    receiverId: number;
    notification: INotificationModel;
}
