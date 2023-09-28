import { ILanguage } from '@shared/models/language/language';

export function findItemIdByName(collection: ILanguage[], name: string) {
    return collection.find(item => item.name === name)?.id;
}

export const MONACO_EDITOR_THEMES = [
    'vs',
    'vs-dark',
    'hc-black',
];
