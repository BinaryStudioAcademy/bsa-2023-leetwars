import { ChallengeStatus } from '@shared/enums/challenge-status';

import { AuditEntity } from '../common/audit-entity/audit-entity';
import { Language } from '../language/language';
import { LanguageVersion } from '../language-version/language-version';
import { Test } from '../test/test';
import { User } from '../user/user';
import { UserSolution } from '../user-solution/user-solution';

export interface ChallengeVersion extends AuditEntity {
    languageId: number;
    challengeId: number;
    initialSolution: string;
    completeSolution: string;
    preloadedCode: string;
    testCases: string;
    exampleTestCases: string;
    status: ChallengeStatus;
    languageVersions: Array<LanguageVersion>;
    solutions: Array<UserSolution>;
    tests: Array<Test>;
    language: Language;
    author: User;
}
