import { CategoryType } from '@shared/enums/category-type';
import { IChallengeLevel } from '../challenge-level/challenge-level';
import { ITag } from '../tag/tag';
import { ILanguage } from '../language/language';

export interface IChallengeGenerateRequest {
    title: string;
    category: CategoryType;
    level?: IChallengeLevel;
    tags: ITag[];
    language?: ILanguage;
}
