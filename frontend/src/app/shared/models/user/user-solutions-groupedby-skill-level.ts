import { LanguageLevel } from '@shared/enums/languageLevel';

import { ITaskCount } from './task-count';

export interface IUserSolutionsGroupedBySkillLevel {
    totalCount: number;
    name: LanguageLevel;
    taskCountDtos: ITaskCount[];
}
