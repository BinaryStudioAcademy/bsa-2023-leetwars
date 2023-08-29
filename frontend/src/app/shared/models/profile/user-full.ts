import { User } from '../user';

import { Challenge } from './challenge';
import { Language } from './language';
import { UserLanguageLevel } from './user-language-level';
import { UserSolution } from './user-solution';

export interface UserFull extends User {
    language: Language;
    userLanguageLevel: UserLanguageLevel;
    userSolution: UserSolution;
    challenge: Challenge;
}
