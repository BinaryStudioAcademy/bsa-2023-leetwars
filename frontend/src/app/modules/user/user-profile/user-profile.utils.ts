import { LanguageLevel } from '@shared/enums/languageLevel';

export const LevelColorMapper = {
    [LanguageLevel.FirstSteps]: { activeColor: '#2db55d', inactiveColor: '#2db55d26' },
    [LanguageLevel.AdvancedBeginner]: { activeColor: '#829a21', inactiveColor: '#829a2142' },
    [LanguageLevel.Competent]: { activeColor: '#ffb800', inactiveColor: '#ffb80026' },
    [LanguageLevel.Proficient]: { activeColor: 'rgb(255, 161, 22)', inactiveColor: '#f57a0026' },
    [LanguageLevel.Master]: { activeColor: '#ef4743', inactiveColor: '#ef474326' },
};
