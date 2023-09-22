import { FriendshipStatus } from '@shared/enums/friendship-status';

export interface IFriendshipPreview {
    friendshipId: number;
    friendId: number;
    friendshipStatus: FriendshipStatus;
}
