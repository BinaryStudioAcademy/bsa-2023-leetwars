import { AfterViewInit, ChangeDetectorRef, Component, ElementRef, HostListener, Input } from '@angular/core';

@Component({
    selector: 'app-steps-of-progress',
    templateUrl: './steps-of-progress.component.html',
    styleUrls: ['./steps-of-progress.component.sass'],
})
export class StepsOfProgressComponent implements AfterViewInit {
    @Input() public steps: string[] = [];

    @Input() public activeStepIndex = 0;

    public progressWidth = 0;

    private progressBarLine!: Element;

    private activeStepIndicator!: Element;

    private readonly largeScreenWidth = 2048;

    constructor(private el: ElementRef, private cdr: ChangeDetectorRef) {}

    @HostListener('window:resize')
    onResize() {
        this.updateProgressBarWidth();
    }

    ngAfterViewInit() {
        if (this.activeStepIndex >= this.steps.length) {
            this.progressWidth = 100;
            this.cdr.detectChanges();

            return;
        }

        this.progressBarLine = this.el.nativeElement.querySelector('.progress-bar-line');
        this.activeStepIndicator = this.el.nativeElement.querySelectorAll('.step-indicator')[this.activeStepIndex];
        this.updateProgressBarWidth();
    }

    private updateProgressBarWidth() {
        if (!this.isActiveStepValid()) {
            return;
        }

        const progressBarWidth = this.progressBarLine?.clientWidth ?? 1; // Ensure non-zero width
        const activeStepLeft =
            (this.activeStepIndicator?.getBoundingClientRect().left || 0) -
            (this.progressBarLine?.getBoundingClientRect().left || 0);

        this.progressWidth = (activeStepLeft / progressBarWidth) * 100 + 1.5; // calculate width in %
        if (window.innerWidth > this.largeScreenWidth) {
            this.progressWidth -= 1.2;
        }

        this.cdr.detectChanges();
    }

    private isActiveStepValid(): boolean {
        return this.activeStepIndex >= 0 && this.activeStepIndex < this.steps.length;
    }
}
