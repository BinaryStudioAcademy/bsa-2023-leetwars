import { Component, Input, OnInit } from '@angular/core';

@Component({
    selector: 'app-progress-bar',
    templateUrl: './progress-bar.component.html',
    styleUrls: ['./progress-bar.component.sass'],
})
export class ProgressBarComponent implements OnInit {
    @Input() total: number = 1000;
    @Input() solved:number = 500;
    @Input() data:string = 'no data';
    @Input() level:string = 'easy';


    constructor() {}

    ngOnInit(): void {}
}
