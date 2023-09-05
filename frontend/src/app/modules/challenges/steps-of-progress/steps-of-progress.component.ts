import {
    AfterViewInit, ChangeDetectorRef, Component, ElementRef,
    EventEmitter, HostListener, Input, OnChanges, Output,
} from '@angular/core';

@Component({
    selector: 'app-steps-of-progress',
    templateUrl: './steps-of-progress.component.html',
    styleUrls: ['./steps-of-progress.component.sass'],
})
export class StepsOfProgressComponent implements AfterViewInit, OnChanges {
    @Input() public steps: string[] = [];

    @Input() public activeStepIndex = 0;

    @Output() stepClick = new EventEmitter<number>();

    public progressWidth = 0;

    private progressBarLine!: Element;

    private activeStepIndicator!: Element;

    private readonly largeScreenWidth = 2048;

    private readonly maxProgressWidth = 100;

    private readonly defaultWidthOffset = 1.5;

    private readonly largeScreenWidthOffset = 1.2;

    constructor(private el: ElementRef, private cdr: ChangeDetectorRef) {}

    @HostListener('window:resize')
    onResize() {
        this.updateProgressBarWidth();
    }

    ngAfterViewInit() {
        if (this.activeStepIndex >= this.steps.length) {
            this.progressWidth = this.maxProgressWidth;
            this.cdr.detectChanges();

            return;
        }

        this.progressBarLine = this.el.nativeElement.querySelector('.progress-bar-line');
        this.updateProgressBarWidth();
    }

    ngOnChanges(): void {
        this.updateProgressBarWidth();
    }

    public onClick(stepNumber: number) {
        this.stepClick.emit(stepNumber);
    }

    private updateProgressBarWidth() {
        if (!this.isActiveStepValid()) {
            return;
        }

        this.activeStepIndicator = this.el.nativeElement.querySelectorAll('.step-indicator')[this.activeStepIndex];

        const progressBarWidth = this.progressBarLine?.clientWidth ?? 1; // Ensure non-zero width
        const activeStepLeft =
            (this.activeStepIndicator?.getBoundingClientRect().left || 0) -
            (this.progressBarLine?.getBoundingClientRect().left || 0);

        this.progressWidth = (activeStepLeft / progressBarWidth) * 100 + this.defaultWidthOffset; // calculate width in %
        if (window.innerWidth > this.largeScreenWidth) {
            this.progressWidth -= this.largeScreenWidthOffset;
        }

        this.cdr.detectChanges();
    }

    private isActiveStepValid(): boolean {
        return this.activeStepIndex >= 0 && this.activeStepIndex < this.steps.length;
    }
}
