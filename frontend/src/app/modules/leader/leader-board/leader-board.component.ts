import { Component, OnInit } from '@angular/core';
import { BaseComponent } from '@core/base/base.component';
import { EventService } from '@core/services/event.service';
import { ToastrNotificationsService } from '@core/services/toastr-notifications.service';
import { UserService } from '@core/services/user.service';
import { FriendshipStatus } from '@shared/enums/friendship-status';
import { INewFriendship } from '@shared/models/friendship/new-friendship';
import { IPageSettings } from '@shared/models/page-settings';
import { IUser } from '@shared/models/user/user';
import { takeUntil } from 'rxjs';

@Component({
    selector: 'app-leader-board',
    templateUrl: './leader-board.component.html',
    styleUrls: ['./leader-board.component.sass'],
})
export class LeaderBoardComponent extends BaseComponent implements OnInit {
    public users: IUser[] = [];

    public currentUser: IUser;

    public userFriendsIds: number[] = [];

    public usersToShow: IUser[] = [];

    public isMyFriendsChecked = false;

    public isLastPage = false;

    public isLastFriendsPage = false;

    public loading = false;

    private page: IPageSettings = {
        pageNumber: 0,
        pageSize: 30,
    };

    private friendsPage: IPageSettings = {
        pageNumber: 0,
        pageSize: 30,
    };

    constructor(
        private userService: UserService,
        private toastrNotification: ToastrNotificationsService,
        private eventService: EventService,
    ) {
        super();
    }

    public ngOnInit(): void {
        this.getUsers();
        this.getCurrentUser();

        this.eventService.userChangedEvent$.pipe(takeUntil(this.unsubscribe$)).subscribe({
            next: (user) => {
                this.currentUser.friendships = user.friendships;
                this.userFriendsIds = user.friendships.map((f) => f.friendId);
            },
            error: () => {
                this.toastrNotification.showError('Server connection error');
            },
        });
    }

    public onScroll() {
        const isFriendsScroll = this.isMyFriendsChecked && !this.isLastFriendsPage;
        const isUsersScroll = !this.isMyFriendsChecked && !this.isLastPage;

        if (isFriendsScroll) {
            this.getFriends();
        } else if (isUsersScroll) {
            this.getUsers();
        }
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
                    this.usersToShow = this.users;
                },
                error: () => {
                    this.loading = false;
                    this.toastrNotification.showError('Server connection error');
                },
            });
    }

    private getFriends() {
        if (this.isLastFriendsPage) {
            return;
        }

        this.friendsPage.pageNumber++;
        this.loading = true;

        this.userService
            .getFriendsLeaderBoard(this.friendsPage)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe({
                next: (users) => {
                    this.loading = false;
                    if (!users.length) {
                        this.isLastFriendsPage = true;

                        return;
                    }
                    this.usersToShow = users;
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

    public isCurrentUser(user: IUser): boolean {
        return user && this.currentUser && user.id === this.currentUser.id;
    }

    public isAddFriendButtonVisible(user: IUser): boolean {
        return !this.isCurrentUser(user) && !this.isFriend(user);
    }

    public isPendingFriendship(user: IUser): boolean {
        return !this.isCurrentUser(user) && this.getFriendshipStatus(user) === FriendshipStatus.Pending;
    }

    public isAcceptedFriendship(user: IUser): boolean {
        return !this.isCurrentUser(user) && this.getFriendshipStatus(user) === FriendshipStatus.Accepted;
    }

    private getFriendshipStatus(user: IUser): FriendshipStatus | undefined {
        return this.currentUser?.friendships?.find((f) => f.friendId === user.id)?.friendshipStatus;
    }

    public isFriend(user: IUser): boolean {
        return user && this.userFriendsIds.includes(user.id);
    }

    public addFriend(user: IUser) {
        const request: INewFriendship = {
            senderId: this.currentUser.id,
            recipientId: user.id,
        };

        this.userService
            .sendFriendshipRequest(request)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe({
                next: (userDto) => {
                    this.currentUser.friendships = userDto.friendships;
                    this.userFriendsIds = userDto.friendships.map((f) => f.friendId);
                },
                error: () => {
                    this.toastrNotification.showError('Server connection error');
                },
            });
    }

    public toggleMyFriends() {
        this.isMyFriendsChecked = !this.isMyFriendsChecked;

        if (this.isMyFriendsChecked) {
            this.friendsPage.pageNumber = 0;
            this.isLastFriendsPage = false;
            this.getFriends();
        } else {
            this.usersToShow = this.users;
        }
    }
}
