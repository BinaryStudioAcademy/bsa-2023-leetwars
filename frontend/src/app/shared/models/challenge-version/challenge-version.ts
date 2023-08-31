import { ChallengeStatus } from '@shared/enums/challenge-status';

import { AuditEntity } from '../common/audit-entity/audit-entity';
import { Language } from '../language/language';
import { LanguageVersion } from '../language-version/language-version';
import { UserSolution } from '../profile/user-solution';
import { Test } from '../test/test';
import { User } from '../user';

export interface ChallengeVersion extends AuditEntity {
    languageId: number;
    challengeId: number;
    initialSolution: string;
    completeSolution: string;
    status: ChallengeStatus;
    languageVersions: Array<LanguageVersion>;
    solutions: Array<UserSolution>;
    tests: Array<Test>;
    language: Language;
    author: User;
}
