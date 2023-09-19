import { LanguageLevel } from '@shared/enums/language-level';
import { SkillLevel } from '@shared/enums/skill-level';

import { Entity } from '../common/entity';

export interface IChallengeLevel extends Entity<number> {
    difficultyLevel: SkillLevel;
    skillLevel: LanguageLevel;
    reward: number;
}
