import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { ScrollComponent } from '@core/base/scroll.component';
import { CodeAnylizerHttpService } from '@core/services/code-anylizer-http.service';
import { SpinnerService } from '@core/services/spinner.service';
import { ToastrNotificationsService } from '@core/services/toastr-notifications.service';
import { DescribeQuestionComponent } from '@modules/challenges/describe-question/describe-question.component';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { IChallengeGenerateRequest } from '@shared/models/challenge-generate/challenge-generate-request';
import { IChallengeGenerateResponse } from '@shared/models/challenge-generate/challenge-generate-response';
import { takeUntil } from 'rxjs';

@Component({
    selector: 'app-home',
    templateUrl: './main-page.component.html',
    styleUrls: ['./main-page.component.sass'],
})
export class MainComponent extends ScrollComponent {
    challengeGenerateRequest: IChallengeGenerateRequest;

    constructor(
        private modalService: NgbModal,
        private codeAnylizerService: CodeAnylizerHttpService,
        private toastrService: ToastrNotificationsService,
        private router: Router,
        private spinnerService: SpinnerService,
    ) {
        super();
    }

    public onBtnGenerateClick() {
        const modalRef = this.modalService.open(DescribeQuestionComponent);

        modalRef.componentInstance.buttons = [
            {
                text: 'Generate',
                handler: () => {
                    modalRef.componentInstance.updateChallengeGenerateRequest();
                    this.generateChallenge();
                    modalRef.close();
                },
            },
            {
                text: 'Cancel',
                handler: () => {
                    modalRef.dismiss();
                },
            },
        ];
        modalRef.componentInstance.challengeGenerateRequestChange.subscribe((request: IChallengeGenerateRequest) => {
            this.challengeGenerateRequest = request;
        });
    }

    private generateChallenge() {
        if (!this.challengeGenerateRequest) {
            return;
        }
        this.spinnerService.show();
        this.codeAnylizerService
            .generateChallenge(this.challengeGenerateRequest)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe({
                next: (response: IChallengeGenerateResponse) => {
                    this.router.navigate(['/challenges/create'], {
                        state: {
                            generatedChallenge: response,
                        },
                    });
                    this.toastrService.showSuccess('Challenge generated successfully');
                },
                error: () => {
                    this.toastrService.showError('Error generating challenge');
                },
                complete: () => {
                    this.spinnerService.hide();
                },
            });
    }
}
