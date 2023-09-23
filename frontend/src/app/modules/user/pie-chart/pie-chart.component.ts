import { Component, Input, OnChanges, SimpleChanges } from '@angular/core';
import { ColorConstants } from '@shared/constants/color-constants';
import { Color, ScaleType } from '@swimlane/ngx-charts';

import { PieChartData } from './data';

@Component({
    selector: 'app-pie-chart',
    templateUrl: './pie-chart.component.html',
    styleUrls: ['./pie-chart.component.sass'],
})
export class PieChartComponent implements OnChanges {
    @Input() currentNumber: number;

    @Input() totalNumber: number;

    @Input() activeColor: string;

    single: PieChartData[] = [];

    colorScheme: Color = {
        name: 'myScheme',
        selectable: true,
        group: ScaleType.Ordinal,
        domain: [ColorConstants.pieChartActiveColor, ColorConstants.inactiveColor],
    };

    view: [number, number] = [140, 140];

    ngOnChanges({ currentNumber, totalNumber }: SimpleChanges): void {
        if (currentNumber && !!totalNumber) {
            this.single = [
                {
                    name: 'Solved',
                    value: this.currentNumber,
                },
                {
                    name: 'Rest',
                    value: this.totalNumber - this.currentNumber,
                },
            ];

            this.colorScheme = {
                name: 'myScheme',
                selectable: true,
                group: ScaleType.Ordinal,
                domain: [this.activeColor, ColorConstants.inactiveColor],
            };
        }
    }
}
