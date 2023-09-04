import { Entity } from '../common/entity';

export interface LanguageVersion extends Entity {
    languageId: number;
    version: string;
}
