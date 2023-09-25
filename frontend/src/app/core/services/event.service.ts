import { Injectable } from '@angular/core';
import { IUser } from '@shared/models/user/user';
import { Subject } from 'rxjs';

@Injectable({
    providedIn: 'root',
})
export class EventService {
    private onUsersStatusesChanged = new Subject<IUser[]>();

    public usersChangedEvent$ = this.onUsersStatusesChanged.asObservable();

    public usersStatusesChanged(users: IUser[]) {
        this.onUsersStatusesChanged.next(users);
    }
}
