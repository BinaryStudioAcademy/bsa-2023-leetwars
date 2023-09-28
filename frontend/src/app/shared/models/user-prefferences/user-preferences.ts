import { ILanguage } from '../language/language';

export interface IUserPreferences {
    language: ILanguage;
    theme: string;
    isWordWrap: boolean;
    tabSize: number;
    fontSize: number;
    isMinimap: boolean;
}
