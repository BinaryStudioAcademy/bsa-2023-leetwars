import { Component, Input, OnChanges, OnInit } from '@angular/core';
import { UserSolution } from '@shared/models/user-solution/user-solution';
import { Color, ScaleType } from '@swimlane/ngx-charts';
import * as moment from 'moment';

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
        return this.solutions.reduce((result, solution) => {
            if (solution.submittedAt && moment(solution.submittedAt).startOf('day').isSame(date)) {
                result++;
            }

            return result;
        }, 0);
    }

    private updateChartData() {
        this.chartData = [];
        this.totalSubmissions = 0;
        this.totalActiveDays = 0;
        this.maxStreak = 0;
        let currentStreak = 0;

        const firstDay = moment().subtract(1, 'year').add(1, 'day').startOf('day')
            .toDate();
        let seriesMonth = moment(firstDay).startOf('month');
        const seriesWeek = moment(firstDay).startOf('week');
        const lastWeek = moment().startOf('week');
        let monthChartData: WeekChartData[] = [];
        let columnId = 0;

        while (seriesWeek <= lastWeek) {
            columnId++;
            const seriesData: DayChartData[] = [];

            for (let i = 6; i >= 0; i--) {
                const weekDate = seriesWeek.clone().add(i, 'day');
                const date = weekDate.toDate();
                const name = weekDate.format('ddd');
                let value = -1; //not set

                if (weekDate.clone().startOf('month').isSame(seriesMonth)) {
                    value = this.getSubmissionsCount(date);
                    this.totalSubmissions += value;
                    if (value > 0) {
                        currentStreak++;
                        this.totalActiveDays++;
                        this.maxStreak = Math.max(this.maxStreak, currentStreak);
                    } else {
                        currentStreak = 0;
                    }
                }

                seriesData.push({ date, name, value });
            }

            const weekChartData: WeekChartData = {
                name: `;${columnId}`,
                series: seriesData,
            };

            this.chartData.push(weekChartData);
            if (seriesMonth.isSame(seriesWeek, 'month')
                || seriesMonth.isSame(seriesWeek.clone().endOf('week'), 'month')) {
                monthChartData.push(weekChartData);
            }

            const nextWeekMonth = seriesWeek.clone().add(1, 'week').startOf('month');

            if (seriesMonth.isSame(nextWeekMonth)) {
                seriesWeek.add(1, 'week');
            } else {
                this.setMonthTitle(monthChartData, seriesMonth.format('MMM'));
                seriesMonth = nextWeekMonth.clone();
                monthChartData = [];
            }
        }
        this.setMonthTitle(monthChartData, seriesMonth.format('MMM'));
    }

    private setMonthTitle(weeks: WeekChartData[], title: string) {
        if (weeks.length > 2) {
            const index = Math.max(0, Math.round(weeks.length / 2) - 1);

            weeks[index].name = title + weeks[index].name;
        }
    }
}
