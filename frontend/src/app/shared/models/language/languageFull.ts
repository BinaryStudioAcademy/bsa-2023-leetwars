import { Entity } from '../common/entity';
import { LanguageVersion } from '../language-version/language-version';

export interface LanguageFull extends Entity {
    name: string,
    languageVersions: Array<LanguageVersion>;
}
