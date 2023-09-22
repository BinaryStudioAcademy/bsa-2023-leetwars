import { Component, Input, OnInit } from '@angular/core';
import { Observable } from 'rxjs';

@Component({
    selector: 'app-arrow-up',
    templateUrl: './arrow-up.component.html',
    styleUrls: ['./arrow-up.component.sass'],
})
export class ArrowUpComponent implements OnInit {
    @Input() onScrollEvent: Observable<void>;

    public showArrowButton = false;

    private heightWhereScrollAppears = 800;

    public ngOnInit(): void {
        this.onScrollEvent.subscribe(() => {
            this.updateArrowButton();
        });
    }

    public afterScroll() {
        this.showArrowButton = false;
    }

    public updateArrowButton() {
        const currentScrollHeight = window.scrollY;

        if (currentScrollHeight > this.heightWhereScrollAppears) {
            this.showArrowButton = true;
        } else {
            this.showArrowButton = false;
        }
    }
}
