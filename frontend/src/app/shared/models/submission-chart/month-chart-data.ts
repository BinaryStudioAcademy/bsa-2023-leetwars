import { DayChartData } from '@shared/models/submission-chart/day-chart-data';

export interface MonthChartData {
    title: string,
    showTitle: boolean,
    days: DayChartData[],
    spacers: string[],
}
