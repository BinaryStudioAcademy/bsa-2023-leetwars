import { LanguageLevel } from '@shared/enums/language-level';
import { IUserSolutionsGroupedBySkillLevel } from '@shared/models/user/user-solutions-groupedby-skill-level';

export const LevelColorMapper = {
    [LanguageLevel.Easy]: { activeColor: '#2db55d', inactiveColor: '#2db55d26' },
    [LanguageLevel.Medium]: { activeColor: '#829a21', inactiveColor: '#829a2142' },
    [LanguageLevel.Difficult]: { activeColor: '#ffb800', inactiveColor: '#ffb80026' },
    [LanguageLevel.Extreme]: { activeColor: 'rgb(255, 161, 22)', inactiveColor: '#f57a0026' },
};

export const getInactiveBars = (result: IUserSolutionsGroupedBySkillLevel[]) =>
    Object.values(LanguageLevel)
        .filter((level) => !result.some((x) => x.name === level))
        .map((r) => ({
            Label: r,
            Done: 0,
            Total: 0,
        }));
