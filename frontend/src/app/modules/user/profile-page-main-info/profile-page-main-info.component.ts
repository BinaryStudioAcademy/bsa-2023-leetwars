import { Component, Input, OnChanges, OnInit, SimpleChanges } from '@angular/core';
import { Router } from '@angular/router';
import { BaseComponent } from '@core/base/base.component';
import { AuthService } from '@core/services/auth.service';
import { ToastrNotificationsService } from '@core/services/toastr-notifications.service';
import { UserService } from '@core/services/user.service';
import * as utils from '@modules/user/profile-page-main-info/profile-page-main.utils';
import { FriendshipStatus } from '@shared/enums/friendship-status';
import { INewFriendship } from '@shared/models/friendship/new-friendship';
import { IUpdateFriendship } from '@shared/models/friendship/update-friendship';
import { IUser } from '@shared/models/user/user';
import { IUserFull } from '@shared/models/user/user-full';
import { IUserSolutionsGroupedBySkillLevel } from '@shared/models/user/user-solutions-groupedby-skill-level';
import { takeUntil } from 'rxjs';

@Component({
    selector: 'app-profile-page-main-info',
    templateUrl: './profile-page-main-info.component.html',
    styleUrls: ['./profile-page-main-info.component.sass'],
})
export class ProfilePageMainInfoComponent extends BaseComponent implements OnChanges, OnInit {
    @Input() user: IUserFull = <IUserFull>{};

    @Input() userSolutions: IUserSolutionsGroupedBySkillLevel[] = [];

    @Input() isCurrentUser: Boolean;

    @Input() isFriend: Boolean;

    @Input() currentUser: IUser;

    @Input() friendshipId?: number;

    communityViews = 0;

    communityLastWeekViews = 0;

    communitySolution = 0;

    communityLastWeekSolution = 0;

    communityDiscuss = 0;

    communityLastWeekDiscuss = 0;

    communityLastWeekReputation = 0;

    constructor(
        private router: Router,
        private authService: AuthService,
        private userService: UserService,
        private toastrNotification: ToastrNotificationsService,
    ) {
        super();
    }

    ngOnInit() {
        this.getCurrentUser();
    }

    ngOnChanges({ user }: SimpleChanges) {
        if (user && this.user) {
            this.updateSolutions();
        }
    }

    onEditProfile() {
        this.router.navigate(['user/profile/edit']);
    }

    addFriend() {
        const request: INewFriendship = {
            senderId: this.currentUser?.id as number,
            recipientId: this.user.id,
        };

        this.userService
            .sendFriendshipRequest(request)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe({
                next: () => {
                    this.toastrNotification.showSuccess('Friendship request sent successfully.');
                },
                error: (error) => {
                    this.toastrNotification.showError(error);
                },
            });
    }

    deleteFriend() {
        const request: IUpdateFriendship = {
            userId: this.currentUser?.id as number,
            friendshipId: this.friendshipId as number,
            friendshipStatus: FriendshipStatus.Declined,
        };

        this.userService
            .updateFriendshipRequest(request)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe({
                next: () => {
                    this.toastrNotification.showSuccess('Friend was deleted successfully.');
                },
                error: (error) => {
                    this.toastrNotification.showError(error);
                },
            });
    }

    isFriendshipStatus(user: IUser, status: string): boolean {
        return !this.isCurrentUserMethod(user) && this.getFriendshipStatus(user) === status;
    }

    isCurrentUserMethod(user: IUser): boolean {
        return user && this.currentUser && user.id === this.currentUser.id;
    }

    private getFriendshipStatus(user: IUser): FriendshipStatus | undefined {
        return this.currentUser?.friendships?.find((f) => f.friendId === user.id)?.friendshipStatus;
    }

    private updateSolutions() {
        this.communityLastWeekSolution = utils.getLastWeekCount(this.user.solutions);
    }

    private getCurrentUser() {
        this.authService.getUser().subscribe((user: IUser) => {
            this.currentUser = user;
        });
    }
}
