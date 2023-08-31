import { IconName } from '@fortawesome/fontawesome-svg-core';

export const SUGGESTION_TYPES = [
    { name: 'Fundamentals', id: 0 },
    { name: 'Rank up', id: 1 },
    { name: 'Practice and Repeat', id: 2 },
    { name: 'Beta', id: 3 },
    { name: 'Random', id: 4 },
];

export const ICONS: IconName[] = ['stairs', 'chart-simple', 'repeat', 'lock', 'circle-question'];

interface SimpleCollection {
    name: string,
    id: number,
}

export function findItemIdByName(collection: SimpleCollection[], name: string) {
    return collection.find(item => item.name === name)?.id ?? 0;
}
