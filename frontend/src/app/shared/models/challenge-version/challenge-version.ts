import { ChallengeStatus } from '@shared/enums/challenge-status';

import { AuditEntity } from '../common/audit-entity/audit-entity';
import { ILanguageFull } from '../language/languageFull';
import { ILanguageVersion } from '../language-version/language-version';
import { IUserSolution } from '../profile/user-solution';
import { ITest } from '../test/test';
import { IUser } from '../user/user';

export interface IChallengeVersion extends AuditEntity<number> {
    languageId: number;
    challengeId: number;
    initialSolution: string;
    completeSolution: string;
    preloadedCode: string;
    testCases: string;
    exampleTestCases: string;
    status: ChallengeStatus;
    languageVersions: Array<ILanguageVersion>;
    solutions: Array<IUserSolution>;
    tests: Array<ITest>;
    language: ILanguageFull;
    author: IUser;
}
