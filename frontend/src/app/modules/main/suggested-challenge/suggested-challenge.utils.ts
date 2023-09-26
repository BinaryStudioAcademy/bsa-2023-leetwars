import { IconName } from '@fortawesome/fontawesome-svg-core';
import { SuggestionType } from '@shared/enums/suggestion-type';
import { ILanguage } from '@shared/models/language/language';

export const SUGGESTION_TYPE_NAMES = [
    { type: SuggestionType.Fundamentals, name: 'Fundamentals' },
    { type: SuggestionType.RankUp, name: 'Rank up' },
    { type: SuggestionType.PracticeAndRepeat, name: 'Practice and Repeat' },
    { type: SuggestionType.Beta, name: 'Beta' },
    { type: SuggestionType.Random, name: 'Random' },
];

export const ICONS: IconName[] = ['stairs', 'chart-simple', 'repeat', 'lock', 'circle-question'];

export function findItemIdByName(collection: ILanguage[], name: string) {
    return collection.find(item => item.name === name)?.id ?? null;
}

export function findSuggestionTypeByName(name: string) {
    return SUGGESTION_TYPE_NAMES.find(item => item.name === name)?.type ?? SuggestionType.Fundamentals;
}
