import { Injectable } from '@angular/core';
import { CanDeactivate, Router } from '@angular/router';
import { AuthService } from '@core/services/auth.service';
import { CodeFightService } from '@core/services/code-fight.service';
import { OnlineEditorPageComponent } from '@modules/challenges/online-editor-page/online-editor-page.component';
import { NgbModal, NgbModalRef } from '@ng-bootstrap/ng-bootstrap';
import { ConfirmationModalComponent } from '@shared/components/confirmation-modal/confirmation-modal.component';
import { ICodeFightEnd } from '@shared/models/codefight/code-fight-end';
import { IUser } from '@shared/models/user/user';

@Injectable({
    providedIn: 'root',
})
export class CodefightGuard implements CanDeactivate<OnlineEditorPageComponent> {
    private user: IUser;

    private modalRef: NgbModalRef;

    constructor(
        private modalService: NgbModal,
        private router: Router,
        private codeFightService: CodeFightService,
        private authService: AuthService,
    ) {
        this.authService.getUser().subscribe((user: IUser) => {
            this.user = user;
        });
    }

    canDeactivate() {
        if (this.router.getCurrentNavigation()?.extras?.state?.['canLeave']) {
            return true;
        }

        this.openModal();

        return this.modalRef.closed;
    }

    openModal() {
        this.modalRef = this.modalService.open(ConfirmationModalComponent, { windowClass: 'code-fight-modal' });

        this.modalRef.componentInstance.titleText = 'Do you really wish to give up?';
        this.modalRef.componentInstance.bodyText = 'After confirmation you will lose this code fight';
        this.modalRef.componentInstance.buttons = [
            {
                text: 'Yes',
                class: 'confirm',
                handler: () => {
                    this.endCodeFight();
                },
            },
            {
                text: 'No',
                class: 'close',
                handler: () => {
                    this.modalRef.dismiss();
                },
            },
        ];

        return this.modalRef;
    }

    private endCodeFight() {
        const codeFightEnd: ICodeFightEnd = {
            isWinner: false,
            senderId: this.user.id,
        };

        this.codeFightService.sendCodeFightEnd(codeFightEnd).subscribe(() => {
            this.modalRef.close();
        });
    }
}
