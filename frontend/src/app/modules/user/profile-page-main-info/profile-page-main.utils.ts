import { UserSolution } from '@shared/models/profile/user-solution';
import * as moment from 'moment';

export function getLastWeekCount(solutions: UserSolution[] | undefined): number {
    if (solutions) {
        return solutions.filter(
            (solution) =>
                new Date(solution.submittedAt!).getTime() >
                    new Date(moment().subtract(1, 'weeks').startOf('isoWeek').format('YYYY-MM-DD')).getTime() &&
                new Date(solution.submittedAt!).getTime() <
                    new Date(moment().subtract(1, 'weeks').endOf('isoWeek').format('YYYY-MM-DD')).getTime(),
        ).length;
    }

    return 0;
}
