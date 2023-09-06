import { LanguageLevel } from "@shared/enums/languageLevel";
import { TaskCountDto } from "./task-count-dto";

export interface UserSolutionsGroupedBySkillLevelDto
{
    name: LanguageLevel;
    taskCountDtos: TaskCountDto[];

}