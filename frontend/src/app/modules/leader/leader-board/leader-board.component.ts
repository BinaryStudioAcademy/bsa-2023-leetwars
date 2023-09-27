import { Component, OnInit } from '@angular/core';
import { BaseComponent } from '@core/base/base.component';
import { EventService } from '@core/services/event.service';
import { ToastrNotificationsService } from '@core/services/toastr-notifications.service';
import { UserService } from '@core/services/user.service';
import { FriendshipStatus } from '@shared/enums/friendship-status';
import { INewFriendship } from '@shared/models/friendship/new-friendship';
import { ILeaderBoardPageSettings } from '@shared/models/leaderboard-page-settings';
import { IUser } from '@shared/models/user/user';
import { Subject, takeUntil } from 'rxjs';

@Component({
    selector: 'app-leader-board',
    templateUrl: './leader-board.component.html',
    styleUrls: ['./leader-board.component.sass'],
})
export class LeaderBoardComponent extends BaseComponent implements OnInit {
    private readonly pageDefault: ILeaderBoardPageSettings = {
        pageNumber: 0,
        pageSize: 30,
        getFriends: false,
    };

    private page: ILeaderBoardPageSettings = { ...this.pageDefault };

    users: IUser[] = [];

    currentUser: IUser;

    userFriendsIds: number[] = [];

    usersToShow: IUser[] = [];

    isMyFriendsChecked = false;

    isLastPage = false;

    loading = false;

    scrollEventSubject = new Subject<void>();

    constructor(
        private eventService: EventService,
        private userService: UserService,
        private toastrNotification: ToastrNotificationsService,
    ) {
        super();
    }

    ngOnInit(): void {
        this.getUsers();
        this.getCurrentUser();

        this.eventService.userChangedEvent$.pipe(takeUntil(this.unsubscribe$)).subscribe({
            next: (user) => {
                this.handleUserDataChange(user);
            },
            error: () => {
                this.toastrNotification.showError('Server connection error');
            },
        });
    }

    onScroll() {
        this.scrollEventSubject.next();

        if (this.isLastPage) {
            return;
        }

        this.getUsers();
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
                next: (user) => {
                    this.handleUserDataChange(user);
                },
                error: (error) => {
                    this.toastrNotification.showError(error);
                },
            });
    }

    toggleMyFriends() {
        this.isMyFriendsChecked = !this.isMyFriendsChecked;
        this.users = [];
        this.isLastPage = false;

        this.page = { ...this.pageDefault, getFriends: this.isMyFriendsChecked };

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

    private handleUserDataChange(user: IUser) {
        this.currentUser.friendships = user.friendships;
        this.userFriendsIds = user.friendships.map((f) => f.friendId);
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

    private getCurrentUser() {
        this.userService
            .getCurrentUser()
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe({
                next: (user) => {
                    this.currentUser = user;
                    this.userFriendsIds = user.friendships.map((f) => f.friendId);
                },
                error: () => {
                    this.toastrNotification.showError('Server connection error');
                },
            });
    }
}
