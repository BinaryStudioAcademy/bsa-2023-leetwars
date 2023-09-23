import { Component, ElementRef, HostListener, Renderer2, ViewChild } from '@angular/core';
import { SpinnerService } from '@core/services/spinner.service';

@Component({
    selector: 'app-landing-page',
    templateUrl: './landing-page.component.html',
    styleUrls: ['./landing-page.component.sass'],
})
export class LandingPageComponent {
    public isScrolled = false;

    public isNavShown = false;

    private windowWidth: number;

    @HostListener('window:scroll', [])
    public onWindowScroll() {
        this.isScrolled = window.scrollY > 0;
    }

    @HostListener('window:resize', ['$event'])
    public onWindowResize(event: Event) {
        const target = event.target as Window;

        if (target.innerWidth > 650 && this.isNavShown) {
            this.updateNavVisibility();
        }
    }

    @ViewChild('navDropdownDiv') dropdownNavigation: ElementRef;

    constructor(private spinnerService: SpinnerService, private renderer: Renderer2) {
        this.windowWidth = window.innerWidth;
    }

    public updateNavVisibility() {
        if (!this.isNavShown) {
            this.renderer.setStyle(this.dropdownNavigation.nativeElement, 'display', 'flex');
            this.isNavShown = true;
        } else if (this.isNavShown) {
            this.renderer.setStyle(this.dropdownNavigation.nativeElement, 'display', 'none');
            this.isNavShown = false;
        }
    }
}
