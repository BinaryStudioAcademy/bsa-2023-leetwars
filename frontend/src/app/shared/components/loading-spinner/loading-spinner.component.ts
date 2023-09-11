import { Component } from '@angular/core';
import { SpinnerService } from '@core/services/spinner.service';

@Component({
    selector: 'app-loading-spinner',
    templateUrl: './loading-spinner.component.html',
    styleUrls: ['./loading-spinner.component.sass'],

})
export class LoadingSpinnerComponent {
    constructor(public spinner: SpinnerService) {}
}
