import { Component, Input, OnInit } from '@angular/core';
import { ColorConstants } from '@shared/constants/color-constants';

@Component({
    selector: 'app-solved-problem',
    templateUrl: './solved-problem.component.html',
    styleUrls: ['./solved-problem.component.sass'],
})
export class SolvedProblemComponent implements OnInit {
    @Input() pieChartActiveColor: string = ColorConstants.pieChartActiveColor;

    @Input() easyLabel: string = 'easy';

    @Input() mediumLabel: string;

    @Input() hardLabel: string;

    @Input() easyTasksCompleted: number = 10;

    @Input() mediumTasksCompleted: number;

    @Input() hardTasksCompleted: number;

    @Input() easyTasks: number;

    @Input() mediumTasks: number;

    @Input() hardTasks: number;

    totalTasks: number;

    totalTasksCompleted: number;

    ngOnInit() {
        this.totalTasks = this.easyTasks + this.mediumTasks + this.hardTasks;
        this.totalTasksCompleted = this.easyTasksCompleted + this.mediumTasksCompleted + this.hardTasksCompleted;
    }
}
