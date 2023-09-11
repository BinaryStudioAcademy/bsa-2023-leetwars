import { LanguageLevel } from '@shared/enums/language-level';

import { Entity } from '../common/entity';

export interface IChallengeLevel extends Entity<number> {
    name: string;
    skillLevel: LanguageLevel;
    reward: number;
}
