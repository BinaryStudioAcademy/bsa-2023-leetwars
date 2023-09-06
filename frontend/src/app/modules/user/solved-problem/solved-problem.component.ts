import { Component, Input, OnInit } from '@angular/core';
import { ColorConstants } from '@shared/constants/color-constants';

export interface IBar {
    Label: string;
    Done: number;
    Total: number;
}

@Component({
    selector: 'app-solved-problem',
    templateUrl: './solved-problem.component.html',
    styleUrls: ['./solved-problem.component.sass'],
})
export class SolvedProblemComponent implements OnInit {
    @Input() pieChartActiveColor: string = ColorConstants.pieChartActiveColor;

    @Input() bars: IBar[] = [];

    totalTasks: number = 0;

    totalTasksCompleted: number = 0;

    constructor() {}

    ngOnInit() {
        this.totalTasks = this.bars.reduce((acc, bar) => acc + bar.Total, 0);
        this.totalTasksCompleted = this.bars.reduce((acc, bar) => acc + bar.Done, 0);
    }
}
