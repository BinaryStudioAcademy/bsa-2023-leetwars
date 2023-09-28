import { CodeFightStatus } from '@shared/enums/code-fight-status';
import { Country } from '@shared/enums/country';
import { Sex } from '@shared/enums/sex';
import { UserStatus } from '@shared/enums/userStatus';
import { IFriendshipPreview } from '@shared/models/friendship/friendship-preview';

export interface IUser {
    id: number;
    timezone: number;
    country?: Country;
    email?: string;
    userName?: string;
    imagePath?: string;
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
    codeFightStatus: CodeFightStatus;
    friendships: IFriendshipPreview[];
}
