import { FriendshipStatus } from '@shared/enums/friendship-status';

export interface IUpdateFriendship {
    userId: number;
    friendshipId: number;
    friendshipStatus: FriendshipStatus;
}
