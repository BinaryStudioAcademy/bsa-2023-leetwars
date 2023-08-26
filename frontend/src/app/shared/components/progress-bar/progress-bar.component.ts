import { Component, Input } from '@angular/core';

@Component({
    selector: 'app-progress-bar',
    templateUrl: './progress-bar.component.html',
    styleUrls: ['./progress-bar.component.sass'],
})
export class ProgressBarComponent {
    @Input() total: number;

    @Input() solved: number;

    @Input() data: string;

    @Input() level: string;
}
