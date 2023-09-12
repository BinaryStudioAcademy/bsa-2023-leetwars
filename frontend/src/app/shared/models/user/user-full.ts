import { IChallenge } from '@shared/models/challenge/challenge';
import { IUser } from '@shared/models/user/user';

import { Badge } from '../badge/badge';
import { ILanguage } from '../profile/language';
import { IUserLanguageLevel } from '../profile/user-language-level';
import { IUserSolution } from '../profile/user-solution';

export interface IUserFull extends IUser {
    totalScore: number;
    reputation: number;
    preferredLanguages: ILanguage[];
    languagesWithLevels: IUserLanguageLevel[];
    solutions: IUserSolution[] | undefined;
    challenges: IChallenge[];
    badges: Badge[];
}
