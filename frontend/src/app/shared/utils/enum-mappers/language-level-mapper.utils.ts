import { LanguageLevel } from '@shared/enums/languageLevel';

export const mapLanguageLevelToEnum = (languageLevel: LanguageLevel) => {
    switch (languageLevel) {
        case LanguageLevel.Easy:
            return 'Easy';
        case LanguageLevel.Medium:
            return 'Medium';
        default:
            return languageLevel;
    }
};
