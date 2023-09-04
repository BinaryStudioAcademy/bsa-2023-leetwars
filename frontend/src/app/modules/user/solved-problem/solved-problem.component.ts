import { Component, Input, OnChanges, OnInit } from '@angular/core';
import { ChallengeService } from '@core/services/challenge.service';
import { ColorConstants } from '@shared/constants/color-constants';
import { Challenge } from '@shared/models/challenge/challenge';
import { UserFull } from '@shared/models/profile/user-full';

@Component({
    selector: 'app-solved-problem',
    templateUrl: './solved-problem.component.html',
    styleUrls: ['./solved-problem.component.sass'],
})
export class SolvedProblemComponent implements OnInit, OnChanges {
    challengesCompleted: Array<Challenge> = [];

    challenges: Array<Challenge> = [];

    constructor(private challengeService: ChallengeService) {}

    ngOnChanges() {
        this.user.solutions?.forEach((element) => {
            this.challengeService.getChallengeById(element.id).subscribe((c) => this.challengesCompleted.push(c));
        });
        this.user.challenges?.forEach((element) => {
            this.challengeService.getChallengeById(element.id).subscribe((c) => this.challenges.push(c));
        });
    }

    @Input() user: UserFull = <UserFull>{};

    @Input() pieChartActiveColor: string = ColorConstants.pieChartActiveColor;

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

    totalTasksCompleted: number = 10;

    ngOnInit() {
        this.totalTasks = this.easyTasks + this.mediumTasks + this.hardTasks;
        this.totalTasksCompleted = this.easyTasksCompleted + this.mediumTasksCompleted + this.hardTasksCompleted;
    }

    calculateTasks() {}
}
