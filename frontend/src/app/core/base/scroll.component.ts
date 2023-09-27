import { Component, HostListener } from '@angular/core';
import { Subject } from 'rxjs';

import { BaseComponent } from './base.component';

@Component({
    selector: 'app-scroll',
    template: '',
})
export class ScrollComponent extends BaseComponent {
    scrollEventSubject = new Subject<void>();

    @HostListener('window:scroll')
    onWindowScroll() {
        this.scrollEventSubject.next();
    }
}
