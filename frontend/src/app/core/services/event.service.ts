import { Injectable } from '@angular/core';
import { IUser } from '@shared/models/user/user';
import { Subject } from 'rxjs';

@Injectable({ providedIn: 'root' })
export class EventService {
    private onUserFriendshipChanged = new Subject<IUser>();

    userChangedEvent$ = this.onUserFriendshipChanged.asObservable();

    userFriendshipChanged(user: IUser) {
        this.onUserFriendshipChanged.next(user);
    }
}
