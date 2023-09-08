import { IDayChartData } from '@shared/models/submission-chart/day-chart-data';

export interface IMonthChartData {
    title: string,
    showTitle: boolean,
    days: IDayChartData[],
    spacers: string[],
}
