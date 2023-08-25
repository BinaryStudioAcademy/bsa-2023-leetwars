import { Component, Input, OnChanges, OnInit } from '@angular/core';
import { UserSolution } from '@shared/models/user-solution/user-solution';
import { Color, ScaleType } from '@swimlane/ngx-charts';
import * as moment from 'moment';
import { Moment } from 'moment';

interface DayChartData {
    date: Date,
    name: string,
    value: number
}

interface WeekChartData {
    name: string,
    series: DayChartData[];
}

@Component({
    selector: 'app-submissions-chart',
    templateUrl: './submissions-chart.component.html',
    styleUrls: ['./submissions-chart.component.scss'],
})
export class SubmissionsChartComponent implements OnInit, OnChanges {
    @Input() solutions: UserSolution[] = [];

    chartData: WeekChartData[] = [];

    totalSubmissions = 0;

    totalActiveDays = 0;

    maxStreak = 0;

    currentStreak = 0;

    chartSize: [number, number] = [700, 110];

    chartColorScheme: Color = {
        name: 'name',
        group: ScaleType.Quantile,
        selectable: false,
        domain: [
            '#00000000',
            '#FFFFFF1F',
            '#61AD00',
            '#61AD00',
            '#61AD00'],
    };

    ngOnInit(): void {
        this.updateChartData();
    }

    ngOnChanges(): void {
        this.updateChartData();
    }

    xAxisTickFormatting(value: string) {
        const columnData = value.split(';');

        return columnData[0];
    }

    private getSubmissionsCount(date: Date) {
        return this.solutions.reduce((previousValue, solution) => {
            let result = previousValue;

            if (solution.submittedAt && moment(solution.submittedAt).startOf('day').isSame(date)) {
                result++;
            }

            return result;
        }, 0);
    }

    private getWeekChartData(month: Moment, week: Moment, weekNumber: number): WeekChartData {
        const weekdays = {
            sunday: 0,
            monday: 1,
            tuesday: 2,
            wednesday: 3,
            thursday: 4,
            friday: 5,
            saturday: 6,
        };

        const seriesData = Object.values(weekdays).reverse().map(dayNumber => this.getDayChartData(month, week, dayNumber));

        return {
            name: `;${weekNumber}`,
            series: seriesData,
        };
    }

    private getDayChartData(month: Moment, week: Moment, dayNumber: number): DayChartData {
        const weekDate = week.clone().add(dayNumber, 'day');
        const date = weekDate.toDate();
        const name = weekDate.format('ddd');
        let submissionsCount = -1; //not set

        if (weekDate.clone().startOf('month').isSame(month)) {
            submissionsCount = this.getSubmissionsCount(date);
            this.nextSubmissionsCount(submissionsCount);
        }

        return { date, name, value: submissionsCount };
    }

    private nextSubmissionsCount(daySubmissionsCount: number) {
        this.totalSubmissions += daySubmissionsCount;

        if (daySubmissionsCount > 0) {
            this.currentStreak++;
            this.totalActiveDays++;
            this.maxStreak = Math.max(this.maxStreak, this.currentStreak);
        } else {
            this.currentStreak = 0;
        }
    }

    // one week can be present in two months
    monthIncludeSomeDayOfWeek(month: Moment, week: Moment) {
        return month.isSame(week, 'month') || month.isSame(week.clone().endOf('week'), 'month');
    }

    private clearChartData() {
        this.chartData = [];
        this.totalSubmissions = 0;
        this.totalActiveDays = 0;
        this.maxStreak = 0;
        this.currentStreak = 0;
    }

    private updateChartData() {
        this.clearChartData();

        const firstDayOfPeriod = moment().subtract(1, 'year').add(1, 'day').startOf('day')
            .toDate();
        const lastWeekOfPeriod = moment().startOf('week');

        let currentMonth = moment(firstDayOfPeriod).startOf('month');
        const currentWeek = moment(firstDayOfPeriod).startOf('week');

        let currentMonthData: WeekChartData[] = [];
        let weekNumber = 0;

        while (currentWeek <= lastWeekOfPeriod) {
            weekNumber++;

            const weekChartData = this.getWeekChartData(currentMonth, currentWeek, weekNumber);

            this.chartData.push(weekChartData);

            // collect month weeks for center title position
            if (this.monthIncludeSomeDayOfWeek(currentMonth, currentWeek)) {
                currentMonthData.push(weekChartData);
            }

            const monthNextWeek = currentWeek.clone().add(1, 'week').startOf('month');

            if (currentMonth.isSame(monthNextWeek)) {
                currentWeek.add(1, 'week');
            } else {
                // new month starts next week
                // align the name of the month by the number of weeks
                this.setMonthTitle(currentMonthData, currentMonth.format('MMM'));
                currentMonth = monthNextWeek.clone();
                currentMonthData = [];
            }
        }
        // align the name of the month by the number of weeks
        this.setMonthTitle(currentMonthData, currentMonth.format('MMM'));
    }

    private setMonthTitle(weeks: WeekChartData[], title: string) {
        if (weeks.length > 2) {
            const index = Math.max(0, Math.round(weeks.length / 2) - 1);

            weeks[index].name = title + weeks[index].name;
        }
    }
}
