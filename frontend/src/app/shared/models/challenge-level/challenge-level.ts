import { Entity } from '../common/entity';

export interface ChallengeLevel extends Entity<number> {
    name: string;
    reward: number;
}
