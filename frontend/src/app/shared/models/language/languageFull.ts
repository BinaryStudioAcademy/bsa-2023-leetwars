import { Entity } from '../common/entity';
import { ILanguageVersion } from '../language-version/language-version';

export interface ILanguageFull extends Entity<number> {
    name: string,
    languageVersions: ILanguageVersion[];
}
