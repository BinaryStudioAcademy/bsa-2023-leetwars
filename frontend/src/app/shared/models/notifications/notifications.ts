import { TypeNotification } from '@shared/enums/type-notification';

import { IBriefChallengeInfo } from '../challenge/brief-challenge';
import { IUpdateFriendship } from '../friendship/update-friendship';
import { IBriefUserInfo } from '../user/brief-user';

export interface INotificationModel {
    typeNotification: TypeNotification;
    sender: IBriefUserInfo;
    receiverId: string;
    challenge: IBriefChallengeInfo;
    updateFriendship: IUpdateFriendship;
    message: string;
    dateSending: Date;
    showFor?: number;
}
