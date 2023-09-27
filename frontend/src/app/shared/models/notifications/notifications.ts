import { TypeNotification } from '@shared/enums/type-notification';

import { IBriefChallengeInfo } from '../challenge/brief-challenge';
import { Entity } from '../common/entity';
import { IBriefUserInfo } from '../user/brief-user';

export interface INotificationModel extends Entity<number> {
    typeNotification: TypeNotification;
    sender: IBriefUserInfo;
    receiverId: string;
    challenge: IBriefChallengeInfo;
    message: string;
    dateSending: Date;
    isRead: boolean;
    showFor?: number;
}
