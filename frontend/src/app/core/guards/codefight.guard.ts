import { Injectable } from '@angular/core';
import { CanDeactivate, Router } from '@angular/router';
import { AuthService } from '@core/services/auth.service';
import { CodeFightService } from '@core/services/code-fight.service';
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
        private codeFightService: CodeFightService,
        private authService: AuthService,
    ) {}

    public canDeactivate() {
        if (this.router.getCurrentNavigation()?.extras?.state?.['canLeave']) {
            return true;
        }

        this.authService.getUser().subscribe((user: IUser) => {
            this.user = user;
        });

        const modalRef = this.modalService.open(ConfirmationModalComponent, { windowClass: 'code-fight-modal' });

        modalRef.componentInstance.titleText = 'Do you really wish to give up?';
        modalRef.componentInstance.bodyText = 'After confirmation you will lose this code fight';
        modalRef.componentInstance.buttons = [
            {
                text: 'Yes',
                class: 'confirm',
                handler: () => {
                    const codeFightEnd: ICodeFightEnd = {
                        isWinner: false,
                        senderId: this.user.id,
                    };

                    this.codeFightService.sendCodeFightEnd(codeFightEnd).subscribe(() => {
                        modalRef.close();
                    });

                    modalRef.closed.subscribe(() => {
                        this.router.navigate(['/']);
                    });
                },
            },
            {
                text: 'No',
                class: 'close',
                handler: () => {
                    modalRef.dismiss();
                },
            },
        ];

        return modalRef.closed;
    }
}
