import { LanguageLevel } from '@shared/enums/language-level';

import { ITaskCount } from './task-count';

export interface IUserSolutionsGroupedBySkillLevel {
    totalCount: number;
    name: LanguageLevel;
    taskCountDtos: ITaskCount[];
}
