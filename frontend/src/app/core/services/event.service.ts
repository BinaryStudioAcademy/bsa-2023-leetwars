import { Injectable } from '@angular/core';
import { IUser } from '@shared/models/user/user';
import { Subject } from 'rxjs';

@Injectable({
    providedIn: 'root',
})
export class EventService {
    private onUsersStatusesChanged = new Subject<IUser[]>();

    private onUserFriendshipChanged = new Subject<IUser>();

    usersChangedEvent$ = this.onUsersStatusesChanged.asObservable();

    userChangedEvent$ = this.onUserFriendshipChanged.asObservable();

    usersStatusesChanged(users: IUser[]) {
        this.onUsersStatusesChanged.next(users);
    }

    userFriendshipChanged(user: IUser) {
        this.onUserFriendshipChanged.next(user);
    }
}
