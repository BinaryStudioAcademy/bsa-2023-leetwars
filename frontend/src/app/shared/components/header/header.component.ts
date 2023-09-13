import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { AuthService } from '@core/services/auth.service';
import { HeaderService } from '@core/services/header-service';
import { ToastrNotificationsService } from '@core/services/toastr-notifications.service';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { IUser } from '@shared/models/user/user';

import { ConfirmationModalComponent } from '../confirmation-modal/confirmation-modal.component';

@Component({
    selector: 'app-header',
    templateUrl: './header.component.html',
    styleUrls: ['./header.component.sass'],
})
export class HeaderComponent {
    showMenu: boolean = false;

    user: IUser;

    constructor(
        private authService: AuthService,
        private modalService: NgbModal,
        private router: Router,
        private headerService: HeaderService,
        private toastrService: ToastrNotificationsService,
    ) {
        this.authService.getUser().subscribe((user) => {
            this.user = user;
        });
    }

    onLogOut() {
        const modalRef = this.modalService.open(ConfirmationModalComponent);

        modalRef.componentInstance.titleText = 'Do you really wish to log out?';
        modalRef.componentInstance.bodyText = `After confirmation you will be logged out of system,
            with all your data safe while you're away`;
        modalRef.componentInstance.buttons = [
            {
                text: 'Yes',
                handler: () => {
                    this.headerService.setShowHeader(false);
                    this.authService.logout();
                    this.router.navigate(['auth/login']);
                    modalRef.close();
                    this.toastrService.showSuccess('Successfully logged out');
                },
            },
            {
                text: 'No',
                handler: () => {
                    this.showMenu = false;
                    modalRef.dismiss();
                },
            },
        ];
    }
}
