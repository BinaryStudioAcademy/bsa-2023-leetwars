import { Entity } from '../common/entity';

export interface LanguageVersion extends Entity<number> {
    languageId: number;
    version: string;
}
