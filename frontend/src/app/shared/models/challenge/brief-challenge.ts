import { Entity } from '../common/entity';
import { IBriefUserInfo } from '../user/brief-user';

export interface IBriefChallengeInfo extends Entity<number> {
    author: IBriefUserInfo
    title: string
}
