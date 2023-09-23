import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';

@Injectable({ providedIn: 'root' })
export class SpinnerService {
    private isLoading$$ = new BehaviorSubject<boolean>(false);

    public isLoading$ = this.isLoading$$.asObservable();

    public show = () => this.isLoading$$.next(true);

    public hide = () => this.isLoading$$.next(false);
}
