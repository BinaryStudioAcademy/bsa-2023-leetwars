import { ILanguage } from '../language/language';

export interface IUserPreferences {
    language: ILanguage;
    theme: string;
    wordWrap: boolean;
    tabSize: number;
    fontSize: number;
}
