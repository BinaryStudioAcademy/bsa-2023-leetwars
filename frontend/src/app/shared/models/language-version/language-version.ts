import { Entity } from '../common/entity';

export interface ILanguageVersion extends Entity<number> {
    languageId: number;
    version: string;
}
