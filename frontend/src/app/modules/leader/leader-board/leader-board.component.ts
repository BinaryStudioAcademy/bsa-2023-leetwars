import { Component, OnInit } from '@angular/core';
import { BaseComponent } from '@core/base/base.component';
import { AuthService } from '@core/services/auth.service';
import { ChallengeService } from '@core/services/challenge.service';
import { LanguageService } from '@core/services/language.service';
import { ToastrNotificationsService } from '@core/services/toastr-notifications.service';
import { UserService } from '@core/services/user.service';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { IChallengeLevel } from '@shared/models/challenge-level/challenge-level';
import { ILanguage } from '@shared/models/language/language';
import { IPageSettings } from '@shared/models/page-settings';
import { IUser } from '@shared/models/user/user';
import { takeUntil } from 'rxjs';

import { ChallengeSelectionModalComponent } from '../challenge-selection-modal/challenge-selection-modal.component';

@Component({
    selector: 'app-leader-board',
    templateUrl: './leader-board.component.html',
    styleUrls: ['./leader-board.component.sass'],
})
export class LeaderBoardComponent extends BaseComponent implements OnInit {
    public users: IUser[] = [];

    public currentUser: IUser;

    public isLastPage = false;

    public loading = false;

    private languages: ILanguage[];

    private levels: IChallengeLevel[];

    private page: IPageSettings = {
        pageNumber: 0,
        pageSize: 30,
    };

    constructor(
        private userService: UserService,
        private authService: AuthService,
        private languageService: LanguageService,
        private challengeService: ChallengeService,
        private toastrNotification: ToastrNotificationsService,
        private modalService: NgbModal,
    ) {
        super();
    }

    public ngOnInit(): void {
        this.authService.getUser().subscribe((user: IUser) => {
            this.currentUser = user;
        });

        this.languageService.getLanguages().subscribe((languages: ILanguage[]) => {
            this.languages = languages;
        });

        this.challengeService.getChallengeLevels().subscribe((levels: IChallengeLevel[]) => {
            this.levels = levels;
        });

        this.getUsers();
    }

    public startCodeFight() {
        // TODO: Send notification

        this.openModal();
    }

    public onScroll() {
        if (this.isLastPage) {
            return;
        }

        this.getUsers();
    }

    private getUsers() {
        if (this.isLastPage) {
            return;
        }

        this.page.pageNumber++;
        this.loading = true;

        this.userService
            .getLeaderBoard(this.page)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe({
                next: (users) => {
                    this.loading = false;
                    if (!users.length) {
                        this.isLastPage = true;

                        return;
                    }
                    this.users = [...this.users, ...users];
                },
                error: () => {
                    this.loading = false;
                    this.toastrNotification.showError('Server connection error');
                },
            });
    }

    private openModal() {
        const challengeSettingsSelect = this.modalService.open(ChallengeSelectionModalComponent);

        challengeSettingsSelect.componentInstance.languages = this.languages;
        challengeSettingsSelect.componentInstance.levels = this.levels;
    }
}
