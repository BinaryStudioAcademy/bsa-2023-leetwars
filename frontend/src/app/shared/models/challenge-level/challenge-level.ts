import { Entity } from '../common/entity';

export interface ChallengeLevel extends Entity {
    name: string;
    reward: number;
}
