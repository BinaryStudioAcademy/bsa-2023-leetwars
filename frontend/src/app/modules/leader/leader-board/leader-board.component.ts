import { Component, OnInit } from '@angular/core';
import { ScrollComponent } from '@core/base/scroll.component';
import { AuthService } from '@core/services/auth.service';
import { ChallengeService } from '@core/services/challenge.service';
import { EventService } from '@core/services/event.service';
import { LanguageService } from '@core/services/language.service';
import { ToastrNotificationsService } from '@core/services/toastr-notifications.service';
import { UserService } from '@core/services/user.service';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { CodeFightStatus } from '@shared/enums/code-fight-status';
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
export class LeaderBoardComponent extends ScrollComponent implements OnInit {
    public users: IUser[] = [];

    public currentUser: IUser;

    public isLastPage = false;

    public loading = false;

    public isCodeFightRequestSent = false;

    public CodeFightStatus = CodeFightStatus;

    private page: IPageSettings = {
        pageNumber: 0,
        pageSize: 30,
    };

    private languages: ILanguage[];

    private levels: IChallengeLevel[];

    constructor(
        private userService: UserService,
        private authService: AuthService,
        private languageService: LanguageService,
        private challengeService: ChallengeService,
        private eventService: EventService,
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

        this.updateUsersStatuses();

        this.getUsers();
    }

    public onScroll() {
        if (this.isLastPage) {
            return;
        }

        this.getUsers();
    }

    public startCodeFight(user: IUser) {
        if (this.isCurrentUserAbleToCodeFight()) {
            this.openModal(user);
        }
    }

    isCurrentUserAbleToCodeFight() {
        return this.currentUser.codeFightStatus === CodeFightStatus.NotInBattle;
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

    private openModal(user: IUser) {
        const challengeSettingsSelect = this.modalService.open(ChallengeSelectionModalComponent);

        challengeSettingsSelect.componentInstance.languages = this.languages;
        challengeSettingsSelect.componentInstance.levels = this.levels;
        challengeSettingsSelect.componentInstance.receiverId = user.id;

        challengeSettingsSelect.closed.subscribe((users: IUser[]) => {
            this.eventService.usersStatusesChanged(users);
        });
    }

    private updateUsersStatuses() {
        this.eventService.usersChangedEvent$.pipe(takeUntil(this.unsubscribe$)).subscribe({
            next: (users: IUser[]) => {
                this.updateCurrentUserCodeFightStatus(users);

                this.updateUsersAfterCodeFightStatusChanged(users);
            },
            error: () => {
                this.toastrNotification.showError('Server connection error');
            },
        });
    }

    private updateCurrentUserCodeFightStatus(users: IUser[]) {
        this.currentUser = users.find((updatedUser) => updatedUser.id === this.currentUser.id) || this.currentUser;
    }

    private updateUsersAfterCodeFightStatusChanged(users: IUser[]) {
        const updatedUsers = this.users.map((user) => {
            const matchingUser = users.find((updatedUser: IUser) => updatedUser.id === user.id);

            return matchingUser ? { ...user, codeFightStatus: matchingUser.codeFightStatus } : user;
        });

        this.users = updatedUsers;
    }
}
