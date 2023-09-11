import { Component, Input, OnInit } from '@angular/core';
import { environment } from '@env/environment';
import { Badge, SlideInfo } from '@shared/models/badge/badge';
import { OwlOptions, SlidesOutputData } from 'ngx-owl-carousel-o';

@Component({
    selector: 'app-badge',
    templateUrl: './badge.component.html',
    styleUrls: ['./badge.component.sass'],
})
export class BadgeComponent implements OnInit {
    @Input() badges: Badge[];

    @Input() startPosition: number = 0;

    items: SlideInfo[];

    customOptions: OwlOptions;

    ngOnInit(): void {
        this.items = this.badges?.map((bdg) => ({
            badge: bdg,
            isActive: bdg === this.badges[this.startPosition],
        }));

        this.loadCarouselOptions();
    }

    onTranslated(data: SlidesOutputData) {
        const centeredItem = data.slides?.find((x) => x.center);

        const itemToChange = this.items.findIndex((x) => x.badge.icon === centeredItem?.id);

        this.items.forEach((x) => {
            x.isActive = false;
        });

        this.items[itemToChange].isActive = true;
    }

    replaceFileExtension(srcPath: string, newExtension: string): string {
        const lastDotIndex = srcPath.lastIndexOf('.');

        const stringBeforeLastDot = srcPath.slice(0, lastDotIndex);

        const newString = stringBeforeLastDot + newExtension;

        return newString;
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

    getIconUrl(item: SlideInfo): string {
        const url = item.isActive ? this.replaceFileExtension(item.badge.icon, '.gif') : item.badge.icon;

        return `${environment.coreUrl}${url}`;
    }
}
