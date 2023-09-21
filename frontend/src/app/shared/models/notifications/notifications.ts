import { TypeNotification } from '@shared/enums/type-notification';

import { IBriefChallengeInfo } from '../challenge/brief-challenge';
import { UpdateFriendship } from '../friendship/update-friendship';
import { IBriefUserInfo } from '../user/brief-user';

export interface INotificationModel {
    typeNotification: TypeNotification;
    sender: IBriefUserInfo;
    challenge: IBriefChallengeInfo;
    updateFriendship: UpdateFriendship;
    message: string;
    dateSending: Date;
}
