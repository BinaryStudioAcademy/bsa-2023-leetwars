import { Component, Input, OnInit } from '@angular/core';
import { Badge } from '@shared/models/badge/badge';
import { OwlOptions, SlidesOutputData } from 'ngx-owl-carousel-o';

@Component({
    selector: 'app-badge',
    templateUrl: './badge.component.html',
    styleUrls: ['./badge.component.sass'],
})
export class BadgeComponent implements OnInit {
    @Input() badges: Badge[];

    @Input() startPosition: number = 0;

    public customOptions: OwlOptions;

    private activeSlides: SlidesOutputData;

    public ngOnInit(): void {
        this.loadCarouselOptions();
    }

    public onTranslated(data: SlidesOutputData) {
        this.activeSlides = data;
    }

    public isCentered(item: Badge) {
        return this.activeSlides.slides?.some((x) => x.center && item.id === +x.id);
    }

    public getIconUrl(item: Badge): string {
        return this.isCentered(item) ? item.iconGif : item.icon;
    }

    private loadCarouselOptions(): void {
        this.customOptions = {
            loop: true,
            mouseDrag: true,
            touchDrag: false,
            pullDrag: false,
            dots: false,
            navSpeed: 700,
            center: true,
            nav: false,
            stagePadding: 0,
            startPosition: this.startPosition,
            responsive: {
                0: {
                    items: 1,
                },
                240: {
                    items: 3,
                },
            },
        };
    }
}
