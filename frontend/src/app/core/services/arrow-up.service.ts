import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';

@Injectable({
    providedIn: 'root',
})
export class ArrowUpService {
    private heightWhereScrollAppears = 800;

    public updateArrowButton(): Observable<boolean> {
        const currentScrollHeight = window.scrollY;

        return of(currentScrollHeight > this.heightWhereScrollAppears);
    }
}
