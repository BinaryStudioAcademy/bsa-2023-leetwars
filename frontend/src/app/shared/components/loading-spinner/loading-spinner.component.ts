import { Component, Input } from '@angular/core';
import { SpinnerService } from '@core/services/spinner.service';

@Component({
    selector: 'app-loading-spinner',
    templateUrl: './loading-spinner.component.html',
    styleUrls: ['./loading-spinner.component.sass'],
})
export class LoadingSpinnerComponent {
    constructor(public spinnerService: SpinnerService) {}

    @Input() overlay: boolean;

    @Input() size = '20px';

    @Input() top = '50%';

    @Input() left = '50%';

    @Input() position = 'fixed';

    @Input() margin = 'auto';
}
