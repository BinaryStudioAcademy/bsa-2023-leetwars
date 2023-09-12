import { Directive, HostListener, Input } from '@angular/core';

@Directive({
    selector: '[appScrollTo]',
})
export class ScrollToDirective {
    @Input() public scrollToId: string;

    @Input() public scrollOffset: number = 0;

    @HostListener('click')
    public onClick() {
        const targetElement = document.querySelector(this.scrollToId);

        if (targetElement) {
            const targetScrollPosition = targetElement.getBoundingClientRect().top + window.scrollY - this.scrollOffset;

            window.scrollTo({ top: targetScrollPosition, behavior: 'smooth' });
        }
    }
}
