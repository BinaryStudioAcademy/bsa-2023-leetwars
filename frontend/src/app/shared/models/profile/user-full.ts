import { Challenge } from '@shared/models/challenge/challenge';
import { User } from '@shared/models/user/user';

import { Language } from './language';
import { UserLanguageLevel } from './user-language-level';
import { UserSolution } from './user-solution';

export interface UserFull extends User {
    preferredLanguages: Language[];
    languageWithLevels: UserLanguageLevel[];
    solutions: UserSolution[] | undefined;
    challenges: Challenge[];
}
