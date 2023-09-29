import { IFriendshipPreview } from '../friendship/friendship-preview';

import { IBriefUserInfo } from './brief-user';

export interface IUserFriendsInfo extends IBriefUserInfo {
    friendships: IFriendshipPreview[];
}
