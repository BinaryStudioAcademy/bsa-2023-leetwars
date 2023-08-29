import { LanguageLevel } from '@shared/enums/languageLevel';

export interface UserLanguageLevel {
    userId: string;
    languageId: number;
    level: LanguageLevel;
}
