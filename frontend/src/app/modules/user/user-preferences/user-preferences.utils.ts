import { ILanguage } from '@shared/models/language/language';

export function findItemIdByName(collection: ILanguage[], name: string) {
    return collection.find(item => item.name === name)?.id ?? null;
}
