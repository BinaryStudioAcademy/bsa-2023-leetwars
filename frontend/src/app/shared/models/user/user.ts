import { Country } from '@shared/enums/country';
import { Sex } from '@shared/enums/sex';
import { UserStatus } from '@shared/enums/userStatus';

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
}
