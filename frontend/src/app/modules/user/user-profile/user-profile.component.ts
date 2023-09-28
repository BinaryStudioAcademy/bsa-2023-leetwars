import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { BaseComponent } from '@core/base/base.component';
import { AuthService } from '@core/services/auth.service';
import { EventService } from '@core/services/event.service';
import { ToastrNotificationsService } from '@core/services/toastr-notifications.service';
import { UserService } from '@core/services/user.service';
import { FriendshipStatus } from '@shared/enums/friendship-status';
import { IFriendshipPreview } from '@shared/models/friendship/friendship-preview';
import { IUser } from '@shared/models/user/user';
import { IUserFull } from '@shared/models/user/user-full';
import { IUserSolutionsGroupedBySkillLevel } from '@shared/models/user/user-solutions-groupedby-skill-level';
import { takeUntil } from 'rxjs';

import { IBar } from '../solved-problem/solved-problem.component';

import { getInactiveBars } from './user-profile.utils';

@Component({
    selector: 'app-user-profile',
    templateUrl: './user-profile.component.html',
    styleUrls: ['./user-profile.component.sass'],
})
export class UserProfileComponent extends BaseComponent implements OnInit {
    fullUser: IUserFull;

    userSolutions: IUserSolutionsGroupedBySkillLevel[] = [];

    bars: IBar[] = [];

    isCurrentUser: Boolean = false;

    isFriend: Boolean = false;

    friendshipId: number | undefined;

    userFriendsIds: number[] = [];

    private user: IUser;

    currentUser: IUser;

    constructor(
        private userService: UserService,
        private authService: AuthService,
        private toastrNotification: ToastrNotificationsService,
        private route: ActivatedRoute,
        private eventService: EventService,
    ) {
        super();
        this.authService.getUser().subscribe((user: IUser) => {
            this.user = user;
            this.currentUser = user;
        });
    }

    ngOnInit(): void {
        this.getChosenUser();

        this.eventService.userChangedEvent$.pipe(takeUntil(this.unsubscribe$)).subscribe({
            next: (updateFriendship) => {
                this.handleUserDataChange(updateFriendship);
            },
            error: () => {
                this.toastrNotification.showError('Server connection error');
            },
        });
    }

    private getUserInfo(id: number) {
        this.userService
            .getFullUser(id)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe({
                next: (result) => {
                    this.user = result;
                    this.fullUser = result;
                    this.getUserFriendships();
                },
                error: () => { this.toastrNotification.showError('User not found'); },
            });
    }

    private getUserChallenges(id: number) {
        this.userService
            .getUserChallengesInfoByTags(id)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe({
                next: (result: IUserSolutionsGroupedBySkillLevel[]) => {
                    this.userSolutions = result;
                    this.bars = [
                        ...result.map((r) => ({
                            Label: r.name,
                            Done: r.taskCountDtos.length,
                            Total: r.totalCount,
                        })),
                        ...getInactiveBars(result),
                    ];
                },
                error: () => {
                    this.toastrNotification.showError('Server connection error');
                },
            });
    }

    private getChosenUser() {
        try {
            this.route.paramMap.subscribe((params) => {
                const userId = Number(params.get('id'));

                this.isCurrentUser = !userId || this.currentUser?.id === userId;
                const curentUserId = this.isCurrentUser ? this.currentUser.id : userId;

                this.getUserInfo(curentUserId);
                this.getUserChallenges(curentUserId);
            });
        } catch (error) {
            this.toastrNotification.showError('User not found');
        }
    }

    private getUserFriendships() {
        this.userService
            .getUserFriendships(this.currentUser.id)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe({
                next: (userFriendsInfo) => {
                    this.userFriendsIds = userFriendsInfo.friendships.map((f) => f.friendId);
                    this.currentUser.friendships = userFriendsInfo.friendships;
                    this.friendshipId = this.currentUser.friendships.find((f) => f.friendId === this.user.id)?.friendshipId;
                    this.isFriend = this.isFriendMethod(this.user);
                },
                error: () => {
                    this.toastrNotification.showError('Server connection error');
                },
            });
    }

    isFriendMethod(user: IUser): boolean {
        return user && this.userFriendsIds.includes(user.id);
    }

    private removeFriendship(friendId: number) {
        this.userFriendsIds = this.userFriendsIds.filter((id) => id !== friendId);
        this.currentUser.friendships = this.currentUser.friendships.filter((f) => f.friendId !== friendId);
    }

    private updateOrAddFriendship(updateFriendship: IFriendshipPreview) {
        this.currentUser.friendships = [
            ...this.currentUser.friendships.filter(
                (friendship) => friendship.friendshipId !== updateFriendship.friendshipId,
            ),
            updateFriendship,
        ];
        this.userFriendsIds = this.currentUser.friendships.map((f) => f.friendId);
    }

    private handleUserDataChange(updateFriendship: IFriendshipPreview) {
        if (updateFriendship.friendshipStatus === FriendshipStatus.Declined) {
            this.removeFriendship(updateFriendship.friendId);
            this.friendshipId = this.currentUser.friendships.find((f) => f.friendId === this.user.id)?.friendshipId;
            this.isFriend = false;
        } else {
            this.updateOrAddFriendship(updateFriendship);
            this.friendshipId = this.currentUser.friendships.find((f) => f.friendId === this.user.id)?.friendshipId;
            this.isFriend = true;
        }
    }
}
