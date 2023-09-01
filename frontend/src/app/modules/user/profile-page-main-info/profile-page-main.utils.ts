import { UserLanguageLevel } from '@shared/models/profile/user-language-level';
import { UserSolution } from '@shared/models/profile/user-solution';
import * as moment from 'moment';

export function sortAndGroupByEnum(arr: UserLanguageLevel[]): UserLanguageLevel[][] {
    arr.sort((a, b) => a.level - b.level);

    const groupedItems: { [key: number]: UserLanguageLevel[] } = {};

    arr.forEach((item) => {
        if (!groupedItems[item.level]) {
            groupedItems[item.level] = [];
        }
        groupedItems[item.level].push(item);
    });

    const result: UserLanguageLevel[][] = Object.values(groupedItems);

    return result;
}

export function getLastWeekCount(solutions: UserSolution[] | undefined): number {
    if (solutions) {
        solutions.filter(
            (solution) =>
                new Date(solution.submittedAt!).getTime() >
                    new Date(moment().subtract(1, 'weeks').startOf('isoWeek').format('YYYY-MM-DD')).getTime() &&
                new Date(solution.submittedAt!).getTime() <
                    new Date(moment().subtract(1, 'weeks').endOf('isoWeek').format('YYYY-MM-DD')).getTime(),
        );

        return solutions.length;
    }

    return 0;
}
