import { User } from '../user';

import { Challenge } from './challenge';
import { Language } from './language';
import { UserLanguageLevel } from './user-language-level';
import { UserSolution } from './user-solution';

export interface UserFull extends User {
    preferredLanguages: Language[];
    languageWithLevels: UserLanguageLevel[];
    solutions: UserSolution[] | undefined;
    challenges: Challenge[];
}
