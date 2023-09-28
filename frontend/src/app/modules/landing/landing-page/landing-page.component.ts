import { Component, ElementRef, HostListener, Renderer2, ViewChild } from '@angular/core';

@Component({
    selector: 'app-landing-page',
    templateUrl: './landing-page.component.html',
    styleUrls: ['./landing-page.component.sass'],
})
export class LandingPageComponent {
    isScrolled = false;

    isNavShown = false;

    private windowWidth: number;

    @HostListener('window:scroll', [])
    onWindowScroll() {
        this.isScrolled = window.scrollY > 0;
    }

    @HostListener('window:resize', ['$event'])
    onWindowResize(event: Event) {
        const target = event.target as Window;

        if (target.innerWidth > 650 && this.isNavShown) {
            this.updateNavVisibility();
        }
    }

    @ViewChild('navDropdownDiv') dropdownNavigation: ElementRef;

    constructor(private renderer: Renderer2) {
        this.windowWidth = window.innerWidth;
    }

    updateNavVisibility() {
        if (!this.isNavShown) {
            this.renderer.setStyle(this.dropdownNavigation.nativeElement, 'display', 'flex');
            this.isNavShown = true;
        } else if (this.isNavShown) {
            this.renderer.setStyle(this.dropdownNavigation.nativeElement, 'display', 'none');
            this.isNavShown = false;
        }
    }
}
