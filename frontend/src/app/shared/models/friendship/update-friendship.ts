import { FriendshipStatus } from '@shared/enums/friendship-status';

export interface UpdateFriendship {
    userId: number;
    friendshipId: number;
    friendshipStatus: FriendshipStatus;
}
