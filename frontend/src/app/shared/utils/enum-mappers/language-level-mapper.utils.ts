import { LanguageLevel } from '@shared/enums/languageLevel';

export const mapLanguageLevelToEnum = (languageLevel: LanguageLevel) => {
    switch (languageLevel) {
        case LanguageLevel.FirstSteps:
            return 'First Steps';
        case LanguageLevel.AdvancedBeginner:
            return 'Advanced Beginner';
        default:
            return languageLevel;
    }
};
