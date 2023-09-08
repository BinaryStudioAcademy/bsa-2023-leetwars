import { Entity } from '../common/entity';

export interface IChallengeLevel extends Entity<number> {
    name: string;
    reward: number;
}
