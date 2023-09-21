import { FriendshipStatus } from '@shared/enums/friendship-status';

export interface FriendshipPreview {
    friendshipId: number;
    friendId: number;
    friendshipStatus: FriendshipStatus;
}
