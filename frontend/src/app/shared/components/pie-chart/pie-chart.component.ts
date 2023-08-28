import { Component, Input, OnInit } from '@angular/core';
import { Color, ScaleType } from '@swimlane/ngx-charts';

import { PieChartData } from './data';

@Component({
    selector: 'app-pie-chart',
    templateUrl: './pie-chart.component.html',
    styleUrls: ['./pie-chart.component.sass'],
})
export class PieChartComponent implements OnInit {
    @Input() currentNumber: number;

    @Input() totalNumber: number;

    @Input() activeColor: string;

    single: PieChartData[] = [];

    colorScheme!: Color;

    view: [number, number] = [140, 140];

    ngOnInit(): void {
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
            domain: [this.activeColor, '#F0F0F0'],
        };
    }
}
