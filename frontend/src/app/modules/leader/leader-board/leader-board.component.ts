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
import { FriendshipStatus } from '@shared/enums/friendship-status';
import { IChallengeLevel } from '@shared/models/challenge-level/challenge-level';
import { IFriendshipPreview } from '@shared/models/friendship/friendship-preview';
import { INewFriendship } from '@shared/models/friendship/new-friendship';
import { ILanguage } from '@shared/models/language/language';
import { ILeaderBoardPageSettings } from '@shared/models/leaderboard-page-settings';
import { IUser } from '@shared/models/user/user';
import { takeUntil } from 'rxjs';

import { ChallengeSelectionModalComponent } from '../challenge-selection-modal/challenge-selection-modal.component';

@Component({
    selector: 'app-leader-board',
    templateUrl: './leader-board.component.html',
    styleUrls: ['./leader-board.component.sass'],
})
export class LeaderBoardComponent extends ScrollComponent implements OnInit {
    users: IUser[] = [];

    currentUser: IUser;

    userFriendsIds: number[] = [];

    usersToShow: IUser[] = [];

    isMyFriendsChecked = false;

    isLastPage = false;

    loading = false;

    isCodeFightRequestSent = false;

    CodeFightStatus = CodeFightStatus;

    private readonly pageDefault: ILeaderBoardPageSettings = {
        pageNumber: 0,
        pageSize: 30,
        hasFriends: false,
    };

    private page: ILeaderBoardPageSettings = { ...this.pageDefault };

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

    ngOnInit(): void {
        this.getCurrentUser();

        this.getUserFriendships();

        this.initializeLevels();

        this.initializeLanguages();

        this.updateUsersStatuses();

        this.getUsers();

        this.eventService.userChangedEvent$.pipe(takeUntil(this.unsubscribe$)).subscribe({
            next: (updateFriendship) => {
                this.handleUserDataChange(updateFriendship);
            },
            error: () => {
                this.toastrNotification.showError('Server connection error');
            },
        });
    }

    onScroll() {
        if (this.isLastPage) {
            return;
        }

        this.getUsers();
    }

    startCodeFight(user: IUser) {
        if (this.isCurrentUserAbleToCodeFight()) {
            this.openModal(user);
        }
    }

    isCurrentUserAbleToCodeFight() {
        return this.currentUser.codeFightStatus === CodeFightStatus.NotInBattle;
    }

    isCurrentUser(user: IUser): boolean {
        return user && this.currentUser && user.id === this.currentUser.id;
    }

    isAddFriendButtonVisible(user: IUser): boolean {
        return !this.isCurrentUser(user) && !this.isFriend(user);
    }

    isFriendshipStatus(user: IUser, status: string): boolean {
        return !this.isCurrentUser(user) && this.getFriendshipStatus(user) === status;
    }

    isFriend(user: IUser): boolean {
        return user && this.userFriendsIds.includes(user.id);
    }

    addFriend(friend: IUser) {
        const request: INewFriendship = {
            senderId: this.currentUser.id,
            recipientId: friend.id,
        };

        this.userService
            .sendFriendshipRequest(request)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe({
                error: (error) => {
                    this.toastrNotification.showError(error);
                },
            });
    }

    toggleMyFriends() {
        this.isMyFriendsChecked = !this.isMyFriendsChecked;
        this.users = [];
        this.isLastPage = false;

        this.page = { ...this.pageDefault, hasFriends: this.isMyFriendsChecked };

        this.getUsers();
    }

    private getFriendshipStatus(user: IUser): FriendshipStatus | undefined {
        return this.currentUser?.friendships?.find((f) => f.friendId === user.id)?.friendshipStatus;
    }

    private handleUsersUpdate(users: IUser[]) {
        this.loading = false;
        if (!users.length) {
            this.isLastPage = true;

            return;
        }
        this.users = [...this.users, ...users];
        this.usersToShow = this.users;
    }

    private handleUserDataChange(updateFriendship: IFriendshipPreview) {
        if (updateFriendship.friendshipStatus === FriendshipStatus.Declined) {
            this.userFriendsIds = this.userFriendsIds.filter((id) => id !== updateFriendship.friendId);
            this.currentUser.friendships = this.currentUser.friendships.filter(
                (f) => f.friendId !== updateFriendship.friendId,
            );

            return;
        }
        this.currentUser.friendships = [
            ...this.currentUser.friendships.filter(
                (friendship) => friendship.friendshipId !== updateFriendship.friendshipId,
            ),
            updateFriendship,
        ];
        this.userFriendsIds = this.currentUser.friendships.map((f) => f.friendId);
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
                    this.handleUsersUpdate(users);
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

    private getCurrentUser() {
        this.authService.getUser().subscribe((user: IUser) => {
            this.currentUser = user;
        });
    }

    private initializeLevels() {
        this.challengeService.getChallengeLevels().subscribe((levels: IChallengeLevel[]) => {
            this.levels = levels;
        });
    }

    private initializeLanguages() {
        this.languageService.getLanguages().subscribe((languages: ILanguage[]) => {
            this.languages = languages;
        });
    }

    private getUserFriendships() {
        this.userService
            .getUserFriendships(this.currentUser.id)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe({
                next: (userFriendsInfo) => {
                    this.userFriendsIds = userFriendsInfo.friendships.map((f) => f.friendId);
                    this.currentUser.friendships = userFriendsInfo.friendships;
                },
                error: () => {
                    this.toastrNotification.showError('Server connection error');
                },
            });
    }
}
