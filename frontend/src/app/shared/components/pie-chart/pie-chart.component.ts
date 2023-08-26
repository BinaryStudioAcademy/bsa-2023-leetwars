import { Component, Input, OnInit } from '@angular/core';
import { Color, ScaleType } from '@swimlane/ngx-charts';

import { PieChartData } from './data';

@Component({
    selector: 'app-pie-chart',
    templateUrl: './pie-chart.component.html',
    styleUrls: ['./pie-chart.component.sass'],
})
export class PieChartComponent implements OnInit {
    @Input() CurrentNumber: number;

    @Input() TotalNumber: number;

    @Input() activeColor: string;

    single: PieChartData[] = [];

    colorScheme!: Color;

    view: [number, number] = [140, 140];

    constructor() {
        Object.assign(this, { this: this.single });
    }

    ngOnInit(): void {
        this.single = [
            {
                name: 'Solved',
                value: this.CurrentNumber,
            },
            {
                name: 'Rest',
                value: this.TotalNumber - this.CurrentNumber,
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
