import { Injectable } from '@angular/core';
import { IFriendshipPreview } from '@shared/models/friendship/friendship-preview';
import { IUser } from '@shared/models/user/user';
import { Subject } from 'rxjs';

@Injectable({
    providedIn: 'root',
})
export class EventService {
    private onUsersStatusesChanged = new Subject<IUser[]>();

    private onUserFriendshipChanged = new Subject<IFriendshipPreview>();

    usersChangedEvent$ = this.onUsersStatusesChanged.asObservable();

    userChangedEvent$ = this.onUserFriendshipChanged.asObservable();

    usersStatusesChanged(users: IUser[]) {
        this.onUsersStatusesChanged.next(users);
    }

    userFriendshipChanged(friendship: IFriendshipPreview) {
        this.onUserFriendshipChanged.next(friendship);
    }
}
