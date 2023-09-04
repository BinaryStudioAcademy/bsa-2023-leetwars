import { Component, Input, OnChanges, OnInit } from '@angular/core';
import { ChallengeService } from '@core/services/challenge.service';
import { ColorConstants } from '@shared/constants/color-constants';
import { ChallengeStatus } from '@shared/enums/challenge-status';
import { Challenge } from '@shared/models/challenge/challenge';
import { UserFull } from '@shared/models/profile/user-full';
import { Subject, takeUntil } from 'rxjs';

@Component({
    selector: 'app-solved-problem',
    templateUrl: './solved-problem.component.html',
    styleUrls: ['./solved-problem.component.sass'],
})
export class SolvedProblemComponent implements OnInit, OnChanges {
    private unsubscribe$ = new Subject<void>();

    challengesCompleted: Array<Challenge> = [];

    challenges: Array<Challenge> = [];

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

    totalTasksCompleted: number;

    constructor(private challengeService: ChallengeService) {}

    ngOnChanges() {
        this.user.solutions?.forEach((element) => {
            this.challengeService
                .getChallengeById(element.challengeVersionId)
                .pipe(takeUntil(this.unsubscribe$))
                .subscribe({
                    next: (challenge) => {
                        if (challenge) {
                            this.challenges.push(challenge as Challenge);
                        }
                    },
                });
        });
        if (this.challenges) {
            console.log(this.challenges);
            this.challengesCompleted = this.challenges.filter((challenge) =>
                challenge.versions.filter((version) => version.status === ChallengeStatus.Approved),
            );
        }
    }

    ngOnInit() {
        this.totalTasks = this.easyTasks + this.mediumTasks + this.hardTasks;
        this.totalTasksCompleted = this.easyTasksCompleted + this.mediumTasksCompleted + this.hardTasksCompleted;
    }
}
