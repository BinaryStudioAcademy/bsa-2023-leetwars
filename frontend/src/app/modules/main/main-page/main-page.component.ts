import { Component } from '@angular/core';
import { ScrollComponent } from '@core/base/scroll.component';

@Component({
    selector: 'app-home',
    templateUrl: './main-page.component.html',
    styleUrls: ['./main-page.component.sass'],
})
export class MainComponent extends ScrollComponent {}
