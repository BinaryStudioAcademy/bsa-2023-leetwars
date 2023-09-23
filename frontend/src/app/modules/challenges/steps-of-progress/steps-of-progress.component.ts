import {
    AfterViewInit,
    ChangeDetectorRef,
    Component,
    ElementRef,
    EventEmitter,
    HostListener,
    Input,
    OnChanges,
    Output,
} from '@angular/core';
import { ChallengeStep } from '@shared/enums/challenge-step';

@Component({
    selector: 'app-steps-of-progress',
    templateUrl: './steps-of-progress.component.html',
    styleUrls: ['./steps-of-progress.component.sass'],
})
export class StepsOfProgressComponent implements AfterViewInit, OnChanges {
    @Input() public steps: ChallengeStep[] = [];

    @Input() public currentStep: ChallengeStep;

    @Output() stepClick = new EventEmitter<ChallengeStep>();

    public progressWidth = 0;

    private progressBarLine!: Element;

    private activeStepIndicator!: Element;

    private readonly largeScreenWidth = 2048;

    private readonly maxProgressWidth = 100;

    private readonly defaultWidthOffset = 1.5;

    private readonly largeScreenWidthOffset = 1.2;

    constructor(private el: ElementRef, private cdr: ChangeDetectorRef) {}

    @HostListener('window:resize')
    public onResize() {
        this.updateProgressBarWidth();
    }

    public ngAfterViewInit() {
        const currentIndex = this.getCurrentStepIndex();

        if (currentIndex >= this.steps.length) {
            this.progressWidth = this.maxProgressWidth;
            this.cdr.detectChanges();

            return;
        }

        this.progressBarLine = this.el.nativeElement.querySelector('.progress-bar-line');
        this.updateProgressBarWidth();
    }

    public ngOnChanges(): void {
        this.updateProgressBarWidth();
    }

    public onClick(step: ChallengeStep) {
        this.stepClick.emit(step);
    }

    private getCurrentStepIndex() {
        return this.steps.findIndex(s => s === this.currentStep);
    }

    private updateProgressBarWidth() {
        if (!this.isActiveStepValid()) {
            return;
        }

        const currentIndex = this.getCurrentStepIndex();

        this.activeStepIndicator = this.el.nativeElement.querySelectorAll('.step-indicator')[currentIndex];

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
        const currentIndex = this.getCurrentStepIndex();

        return currentIndex >= 0 && currentIndex < this.steps.length;
    }
}
