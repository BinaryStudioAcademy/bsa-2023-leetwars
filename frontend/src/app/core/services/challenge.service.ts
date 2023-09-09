import { Injectable } from '@angular/core';
import { HttpResponse } from '@microsoft/signalr';
import { Challenge } from '@shared/models/challenge/challenge';
import { CodeRunRequest } from '@shared/models/code-run-request/code-run-request';
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

    public runTests(request: CodeRunRequest): Observable<HttpResponse> {
        return this.httpService.postRequest<HttpResponse>(`${this.challengesRoute}test`, request);
    }
}
