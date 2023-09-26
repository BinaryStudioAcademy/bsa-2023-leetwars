import { CategoryType } from "@shared/enums/category-type";
import { IChallengeLevel } from "../challenge-level/challenge-level";
import { ITag } from "../tag/tag";
import { ILanguage } from "../language/language";

export interface IChallengeGenerateResponse{
    description: string;
    completeSolution: string;
    initialSolution: string;
    exampleTestCases: string; 
    testCases: string;
    title: string;
    category: CategoryType;
    level: IChallengeLevel;
    tags: ITag[];
    language?: ILanguage;
}