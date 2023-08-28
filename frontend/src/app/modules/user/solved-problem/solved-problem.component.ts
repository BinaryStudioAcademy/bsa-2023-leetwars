import { Component, Input, OnInit } from '@angular/core';

@Component({
    selector: 'app-solved-problem',
    templateUrl: './solved-problem.component.html',
    styleUrls: ['./solved-problem.component.sass'],
})
export class SolvedProblemComponent implements OnInit {
    @Input() pieChartActiveColor: string = '#FFA116';

    @Input() easyLabel: string;

    @Input() mediumLabel: string;

    @Input() hardLabel: string;

    @Input() easyTasksCompleted: number;

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
