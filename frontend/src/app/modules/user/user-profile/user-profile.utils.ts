import { LanguageLevel } from '@shared/enums/languageLevel';
import { IUserSolutionsGroupedBySkillLevel } from '@shared/models/user/user-solutions-groupedby-skill-level';

export const LevelColorMapper = {
    [LanguageLevel.None]: { activeColor: '#2db55d', inactiveColor: '#2db55d26' },
    [LanguageLevel.Easy]: { activeColor: '#829a21', inactiveColor: '#829a2142' },
    [LanguageLevel.Medium]: { activeColor: '#ffb800', inactiveColor: '#ffb80026' },
    [LanguageLevel.Difficult]: { activeColor: 'rgb(255, 161, 22)', inactiveColor: '#f57a0026' },
    [LanguageLevel.Extreme]: { activeColor: '#ef4743', inactiveColor: '#ef474326' },
};

export const getInactiveBars = (result: IUserSolutionsGroupedBySkillLevel[]) =>
    Object.values(LanguageLevel)
        .filter((level) => !result.some((x) => x.name === level))
        .map((r) => ({
            Label: r,
            Done: 0,
            Total: 0,
        }));
