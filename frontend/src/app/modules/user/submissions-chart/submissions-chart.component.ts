import { Component, Input, OnChanges, OnInit } from '@angular/core';
import { getChartData } from '@modules/user/submissions-chart/submissions-chart.utils';
import { UserSolution } from '@shared/models/profile/user-solution';
import { MonthChartData } from '@shared/models/submission-chart/month-chart-data';

@Component({
    selector: 'app-submissions-chart',
    templateUrl: './submissions-chart.component.html',
    styleUrls: ['./submissions-chart.component.sass'],
})
export class SubmissionsChartComponent implements OnInit, OnChanges {
    @Input() solutions: UserSolution[] | undefined = [];

    chartData: MonthChartData[] = [];

    totalSubmissions = 0;

    totalActiveDays = 0;

    maxStreak = 0;

    currentStreak = 0;

    ngOnInit(): void {
        this.updateChartData();
    }

    ngOnChanges(): void {
        this.updateChartData();
    }

    private clearChartData() {
        this.chartData = [];
        this.totalSubmissions = 0;
        this.totalActiveDays = 0;
        this.maxStreak = 0;
    }

    private updateChartData() {
        this.clearChartData();

        if (this.solutions) {
            this.chartData = getChartData(this.solutions);
        }

        const allDaysData = this.chartData.flatMap((item) => item.days);

        allDaysData.forEach((dayData) => this.updateTotalData(dayData.value));
    }

    private updateTotalData(daySubmissionsCount: number) {
        this.totalSubmissions += daySubmissionsCount;

        if (daySubmissionsCount > 0) {
            this.currentStreak++;
            this.totalActiveDays++;
            this.maxStreak = Math.max(this.maxStreak, this.currentStreak);
        } else {
            this.currentStreak = 0;
        }
    }
}
