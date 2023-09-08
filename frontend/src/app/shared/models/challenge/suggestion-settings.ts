import { SuggestionType } from '@shared/enums/suggestion-type';

export interface ISuggestionSettings {
    languageId: number;
    suggestionType: SuggestionType;
}
