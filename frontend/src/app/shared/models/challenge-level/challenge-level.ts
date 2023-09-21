import { LanguageLevel } from '@shared/enums/language-level';

import { Entity } from '../common/entity';

export interface IChallengeLevel extends Entity<number> {
    skillLevel: LanguageLevel;
    reward: number;
}
