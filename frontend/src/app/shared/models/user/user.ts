import { Country } from '@shared/enums/country';
import { Sex } from '@shared/enums/sex';
import { UserStatus } from '@shared/enums/userStatus';
import { FriendshipPreview } from '@shared/models/friendship/friendship-preview';

export interface IUser {
    id: number;
    timezone: number;
    country?: Country;
    email?: string;
    userName?: string;
    image?: string;
    sex: Sex;
    userStatus: UserStatus;
    birthDate?: Date;
    firstName?: string;
    lastName?: string;
    totalScore: number;
    reputation: number;
    registeredAt: Date;
    isSubscribed: boolean;
    isBanned: boolean;
    friendships: FriendshipPreview[];
}
