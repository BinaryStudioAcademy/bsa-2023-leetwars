import { TypeNotification } from '@shared/enums/type-notification';

export interface NotificationModel {
    TypeNotification: TypeNotification,
    Message: string,
    DateSending: Date
}
