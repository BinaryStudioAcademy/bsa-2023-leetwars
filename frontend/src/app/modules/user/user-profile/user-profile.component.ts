import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { BaseComponent } from '@core/base/base.component';
import { AuthService } from '@core/services/auth.service';
import { EventService } from '@core/services/event.service';
import { ToastrNotificationsService } from '@core/services/toastr-notifications.service';
import { UserService } from '@core/services/user.service';
import { FriendshipStatus } from '@shared/enums/friendship-status';
import { IFriendshipPreview } from '@shared/models/friendship/friendship-preview';
import { INewFriendship } from '@shared/models/friendship/new-friendship';
import { IUser } from '@shared/models/user/user';
import { IUserFull } from '@shared/models/user/user-full';
import { IUserSolutionsGroupedBySkillLevel } from '@shared/models/user/user-solutions-groupedby-skill-level';
import { catchError, EMPTY, map, Observable, switchMap, takeUntil, tap, throwError } from 'rxjs';

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

    friendshipId?: number;

    userFriendsIds: number[] = [];

    private user: IUser;

    currentUser: IUser;

    currentUserFriends: IFriendshipPreview[];

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

    private getUserInfo(id: number): Observable<void> {
        return this.userService
            .getFullUser(id)
            .pipe(
                takeUntil(this.unsubscribe$),
                map((result) => {
                    this.user = result;
                    this.fullUser = result;

                    return undefined;
                }),
                catchError(() => {
                    this.toastrNotification.showError('User not found');

                    return EMPTY;
                }),
            );
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
        this.route.paramMap.pipe(
            switchMap((params) => {
                const userId = Number(params.get('id'));

                this.isCurrentUser = !userId || this.user?.id === userId;
                const currentUserId = this.isCurrentUser ? this.currentUser.id : userId;

                return this.getUserInfo(currentUserId).pipe(
                    switchMap(async () => this.getUserChallenges(currentUserId)),
                    switchMap(() => this.getUserFriendships(currentUserId)),
                    catchError((error) => {
                        this.toastrNotification.showError(`Error: ${error}`);

                        return EMPTY;
                    }),
                );
            }),
            tap(() => {
                this.isFriend = this.isFriendMethod(this.user);
            }),
        ).subscribe();
    }

    private getUserFriendships(friendId: number): Observable<void> {
        const data: INewFriendship = { senderId: this.currentUser.id, recipientId: friendId };

        return this.userService
            .getOneUserFriend(data)
            .pipe(
                takeUntil(this.unsubscribe$),
                map((friendShips: IFriendshipPreview) => {
                    if (friendShips === null) {
                        const emptyFriends: IFriendshipPreview =
                        {
                            friendshipStatus: FriendshipStatus.Accepted,
                            friendshipId: 0,
                            friendId: -1,
                        };

                        this.userFriendsIds.push(-1);
                        this.currentUser.friendships.push(emptyFriends);
                        this.friendshipId = 0;

                        return undefined;
                    }

                    this.userFriendsIds.push(friendShips.friendId);
                    this.currentUser.friendships.push(friendShips);
                    this.friendshipId = this.currentUser.friendships.find((f) => f.friendId === this.user.id)?.friendshipId;

                    return undefined;
                }),
                catchError((error) => {
                    this.toastrNotification.showError(error);

                    return throwError(() => error);
                }),
            );
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
