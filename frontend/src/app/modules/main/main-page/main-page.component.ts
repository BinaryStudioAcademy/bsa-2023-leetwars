import { Component, OnDestroy, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { BaseComponent } from '@core/base/base.component';
import { BroadcastHubService } from '@core/hubs/broadcast-hub.service';
import { CodeAnylizerHttpService } from '@core/services/code-anylizer-http.service';
import { SpinnerService } from '@core/services/spinner.service';
import { ToastrNotificationsService } from '@core/services/toastr-notifications.service';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { DescribeQuestionComponent } from '@shared/components/describe-question/describe-question/describe-question.component';
import { IChallengeGenerateRequest } from '@shared/models/challenge-generate/challenge-generate-request';
import { IChallengeGenerateResponse } from '@shared/models/challenge-generate/challenge-generate-response';
import { takeUntil } from 'rxjs';

@Component({
    selector: 'app-home',
    templateUrl: './main-page.component.html',
    styleUrls: ['./main-page.component.sass'],
})
export class MainComponent extends BaseComponent implements OnInit, OnDestroy {
    challengeGenerateRequest: IChallengeGenerateRequest;
    constructor(private broadcastHub: BroadcastHubService, private modalService: NgbModal, private codeAnylizerService: CodeAnylizerHttpService, private toastrService: ToastrNotificationsService, private router: Router, private spinnerService: SpinnerService) {
        super();
    }

    async ngOnInit() {
        await this.broadcastHub.start();
        this.broadcastHub.listenMessages((msg) => {
            console.info(`The next broadcast message was received: ${msg}`);
        });
    }

    override async ngOnDestroy() {
        super.ngOnDestroy();
        await this.broadcastHub.stop();
    }

    public onBtnGenerateClick() {
        
        const modalRef = this.modalService.open(DescribeQuestionComponent, { windowClass: 'delete-modal' });
        modalRef.componentInstance.buttons = [
            {
                text: 'Yes',
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
                    this.spinnerService.show();
                    this.router.navigate(['/challenges/create'], {
                        state: {
                            myComplexObject: response,
                            
                        },
                    });
                    console.log(response);
                    this.toastrService.showSuccess('Challenge generated successfully');
                },
                error: (error) => {
                    this.toastrService.showError('Error generating challenge');
                }
            });
    }

}
