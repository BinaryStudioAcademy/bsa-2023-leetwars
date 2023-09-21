import { TypeNotification } from '@shared/enums/type-notification';

import { IBriefChallengeInfo } from '../challenge/brief-challenge';
import { IBriefUserInfo } from '../user/brief-user';

export interface INotificationModel {
    typeNotification: TypeNotification,
    sender: IBriefUserInfo,
    challenge: IBriefChallengeInfo
    message: string,
    dateSending: Date
}
