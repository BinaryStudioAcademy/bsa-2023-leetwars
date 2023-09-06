import { LanguageLevel } from '@shared/enums/language-level';

import { Entity } from '../common/entity';

export interface ChallengeLevel extends Entity {
    name: string;
    skillLevel: LanguageLevel;
    reward: number;
}
