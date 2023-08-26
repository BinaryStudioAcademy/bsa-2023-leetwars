import { Component, Input } from '@angular/core';

@Component({
    selector: 'app-solved-problem',
    templateUrl: './solved-problem.component.html',
    styleUrls: ['./solved-problem.component.sass'],
})
export class SolvedProblemComponent {
    constructor() {}

    @Input() color: string;

    @Input() easyTasksCompleted: number = 100;

    @Input() mediumTasksCompleted: number = 250;

    @Input() hardTasksCompleted: number = 550;

    @Input() easyTasks: number = 300;

    @Input() mediumTasks: number = 500;

    @Input() hardTasks: number = 700;

    @Input() totalTasks: number = this.easyTasks + this.mediumTasks + this.hardTasks;

    @Input() totalTasksCompleted: number =
        this.easyTasksCompleted + this.mediumTasksCompleted + this.hardTasksCompleted;
}
