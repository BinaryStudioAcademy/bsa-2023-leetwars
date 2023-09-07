import { IChallenge } from '@shared/models/challenge/challenge';
import { IUser } from '@shared/models/user/user';

import { ILanguage } from './language';
import { IUserLanguageLevel } from './user-language-level';
import { IUserSolution } from './user-solution';

export interface IUserFull extends IUser {
    preferredLanguages: ILanguage[];
    languagesWithLevels: IUserLanguageLevel[];
    solutions: IUserSolution[] | undefined;
    challenges: IChallenge[];
}
