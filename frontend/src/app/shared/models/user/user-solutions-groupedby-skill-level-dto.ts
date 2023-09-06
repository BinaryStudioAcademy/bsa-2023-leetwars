import { LanguageLevel } from "@shared/enums/languageLevel";
import { TaskCountDto } from "./task-count-dto";

export interface IUserSolutionsGroupedBySkillLevel
{
    totalCount: number;
    name: LanguageLevel;
    taskCountDtos: TaskCountDto[];

}