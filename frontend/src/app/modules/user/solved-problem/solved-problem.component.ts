import { Component, Input, OnChanges, SimpleChanges,} from '@angular/core';
import { ColorConstants } from '@shared/constants/color-constants';
import { LanguageLevel } from '@shared/enums/languageLevel';


export interface IBar {
    Label: LanguageLevel;
    Done: number;
    Total: number;
}

@Component({
    selector: 'app-solved-problem',
    templateUrl: './solved-problem.component.html',
    styleUrls: ['./solved-problem.component.sass'],
})
export class SolvedProblemComponent implements OnChanges {
    @Input() pieChartActiveColor: string = ColorConstants.pieChartActiveColor;

    @Input() bars: IBar[] = [];

    totalTasks: number = 0;

    totalTasksCompleted: number = 0;

    constructor() {}


    ngOnChanges({bars}: SimpleChanges) {
        if(bars){
        this.totalTasks = this.bars.reduce((acc, bar) => acc + bar.Total, 0);
        this.totalTasksCompleted = this.bars.reduce((acc, bar) => acc + bar.Done, 0);
    }}
    
    
}
