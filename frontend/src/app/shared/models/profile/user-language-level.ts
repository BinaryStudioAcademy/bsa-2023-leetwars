import { LanguageLevel } from '@shared/enums/languageLevel';

export interface IUserLanguageLevel {
    userId: string;
    languageId: number;
    level: LanguageLevel;
}
