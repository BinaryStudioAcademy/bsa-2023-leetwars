import { CategoryType } from '@shared/enums/category-type';

import { IChallengeLevel } from '../challenge-level/challenge-level';
import { ILanguage } from '../language/language';
import { ITag } from '../tag/tag';

export interface IChallengeGenerateResponse {
    description: string;
    completeSolution: string;
    initialSolution: string;
    exampleTestCases: string;
    testCases: string;
    title: string;
    category: CategoryType;
    level: IChallengeLevel;
    tags: ITag[];
    language: ILanguage;
}
