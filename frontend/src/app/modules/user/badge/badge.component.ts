import { Component, Input, OnInit } from '@angular/core';
import { environment } from '@env/environment';
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

    activeSlides: SlidesOutputData;

    customOptions: OwlOptions;

    ngOnInit(): void {
        this.loadCarouselOptions();
    }

    onTranslated(data: SlidesOutputData) {
        this.activeSlides = data;
    }

    isCentered(item: Badge) {
        return this.activeSlides.slides?.some((x) => x.center && item.id === +x.id);
    }

    loadCarouselOptions(): void {
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
                    items: 3,
                },
                435: {
                    items: 5,
                },
            },
        };
    }

    getIconUrl(item: Badge): string {
        const url = this.isCentered(item) ? item.iconGif : item.icon;

        return `${environment.coreUrl}${url}`;
    }
}
