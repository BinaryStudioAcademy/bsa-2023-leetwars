import { LanguageLevel } from '@shared/enums/language-level';

export interface IUserLanguageLevel {
    userId: string;
    languageId: number;
    level: LanguageLevel;
}
