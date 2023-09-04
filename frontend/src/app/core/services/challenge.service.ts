import { Injectable } from '@angular/core';
import { Challenge } from '@shared/models/challenge/challenge';
import { Observable } from 'rxjs';

import { HttpInternalService } from './http-internal.service';

@Injectable({
    providedIn: 'root',
})
export class ChallengeService {
    challengesRoute: string = '/challenge/';

    constructor(private httpService: HttpInternalService) {}

    public getChallengeById(id: number): Observable<Challenge> {
        return this.httpService.getRequest<Challenge>(`${this.challengesRoute}${id}`);
    }
}
