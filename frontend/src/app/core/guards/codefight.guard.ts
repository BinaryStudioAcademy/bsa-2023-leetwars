import { Injectable } from '@angular/core';
import { CanDeactivate, Router } from '@angular/router';
import { AuthService } from '@core/services/auth.service';
import { ChallengeService } from '@core/services/challenge.service';
import { OnlineEditorPageComponent } from '@modules/challenges/online-editor-page/online-editor-page.component';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { ConfirmationModalComponent } from '@shared/components/confirmation-modal/confirmation-modal.component';
import { ICodeFightEnd } from '@shared/models/codefight/code-fight-end';
import { IUser } from '@shared/models/user/user';

@Injectable({
    providedIn: 'root',
})
export class CodefightGuard implements CanDeactivate<OnlineEditorPageComponent> {
    private user: IUser;

    constructor(
        private modalService: NgbModal,
        private router: Router,
        private challengeService: ChallengeService,
        private authService: AuthService,
    ) {}

    public canDeactivate() {
        if (this.router.getCurrentNavigation()?.extras?.state?.['canLeave']) {
            return true;
        }

        this.authService.getUser().subscribe((user: IUser) => {
            this.user = user;
        });

        const modalRef = this.modalService.open(ConfirmationModalComponent);

        modalRef.componentInstance.titleText = 'Do you really wish to give up?';
        modalRef.componentInstance.bodyText = 'After confirmation you will lose this code fight';
        modalRef.componentInstance.buttons = [
            {
                text: 'Yes',
                handler: () => {
                    const codeFightEnd: ICodeFightEnd = {
                        isWinner: false,
                        senderId: this.user.id,
                    };

                    this.challengeService.sendCodeFightEnd(codeFightEnd).subscribe(() => {
                        modalRef.close();
                    });

                    modalRef.closed.subscribe(() => {
                        this.router.navigate(['/']);
                    });
                },
            },
            {
                text: 'No',
                handler: () => {
                    modalRef.dismiss();
                },
            },
        ];

        return modalRef.closed;
    }
}
