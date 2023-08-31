import { UserSolution } from '@shared/models/profile/user-solution';
import { DayChartData } from '@shared/models/submission-chart/day-chart-data';
import { MonthChartData } from '@shared/models/submission-chart/month-chart-data';
import * as moment from 'moment/moment';
import { Moment } from 'moment/moment';

function getBlankArray(arrayLength: number) {
    return Array<string>(arrayLength).fill('');
}

function getFirstDayOfPeriod() {
    return moment().subtract(1, 'year').add(1, 'day').startOf('day');
}

function getLastDayOfPeriod() {
    return moment().startOf('day');
}

function mouthCountInPeriod(dateStart: Moment, dateEnd: Moment) {
    const firstDateOfFirstMonth = dateStart.clone().startOf('month');
    const lastDateOfLastMonth = dateEnd.clone().endOf('month');

    return lastDateOfLastMonth.diff(firstDateOfFirstMonth, 'month') + 1;
}

function weekCountInPeriod(dateStart: Moment, dateEnd: Moment) {
    const firstDateOfFirstWeek = dateStart.clone().startOf('week');
    const lastDateOfLastWeek = dateEnd.clone().endOf('week');

    return lastDateOfLastWeek.diff(firstDateOfFirstWeek, 'week') + 1;
}

function dayCountInPeriod(dateStart: Moment, dateEnd: Moment) {
    const firstDate = dateStart.clone().startOf('day');
    const lastDate = dateEnd.clone().endOf('day');

    return lastDate.diff(firstDate, 'day') + 1;
}

function getDayChartData(date: Date, solutions: UserSolution[]): DayChartData {
    const value = solutions?.reduce((previousValue, solution) => {
        let result = previousValue;

        if (solution.submittedAt && moment(solution.submittedAt).startOf('day').isSame(date)) {
            result++;
        }

        return result;
    }, 0);

    return { date, value, fill: value > 0 };
}

function getMonthChardData(index: number, solutions: UserSolution[]): MonthChartData {
    let firstDayOfMonth = moment().startOf('month').subtract(index, 'month');
    let lastDayOfMonth = firstDayOfMonth.clone().endOf('month').startOf('day');

    if (firstDayOfMonth < getFirstDayOfPeriod()) {
        firstDayOfMonth = getFirstDayOfPeriod();
    }
    if (lastDayOfMonth > getLastDayOfPeriod()) {
        lastDayOfMonth = getLastDayOfPeriod();
    }

    const weekCount = weekCountInPeriod(firstDayOfMonth, lastDayOfMonth);
    const dayCount = dayCountInPeriod(firstDayOfMonth, lastDayOfMonth);

    const days = getBlankArray(dayCount);
    const daysChartData = days.map((day, dayIndex) => {
        const date = firstDayOfMonth.clone().add(dayIndex, 'day');

        return getDayChartData(date.toDate(), solutions);
    });

    return {
        title: firstDayOfMonth.format('MMM'),
        spacers: getBlankArray(firstDayOfMonth.day()),
        showTitle: weekCount > 3,
        days: daysChartData,
    };
}

export function getChartData(solutions: UserSolution[]): MonthChartData[] {
    const monthCount = mouthCountInPeriod(getFirstDayOfPeriod(), moment());
    const months = getBlankArray(monthCount);

    const result = months.map((month, index) => getMonthChardData(index, solutions)).reverse();

    return result;
}
