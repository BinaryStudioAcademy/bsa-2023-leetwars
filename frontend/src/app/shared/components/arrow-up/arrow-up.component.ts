import { Component, Input, OnInit } from '@angular/core';
import { Observable } from 'rxjs';

@Component({
    selector: 'app-arrow-up',
    templateUrl: './arrow-up.component.html',
    styleUrls: ['./arrow-up.component.sass'],
})
export class ArrowUpComponent implements OnInit {
    @Input() onScrollEvent: Observable<void>;

    showArrowButton = false;

    private heightWhereScrollAppears = 800;

    ngOnInit(): void {
        this.onScrollEvent.subscribe(() => {
            this.updateArrowButton();
        });
    }

    afterScroll() {
        this.showArrowButton = false;
    }

    updateArrowButton() {
        const currentScrollHeight = window.scrollY;

        this.showArrowButton = currentScrollHeight > this.heightWhereScrollAppears;
    }
}
