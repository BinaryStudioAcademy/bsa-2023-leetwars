import { HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { HttpInternalService } from '@core/services/http-internal.service';
import { IChallenge } from '@shared/models/challenge/challenge';
import { IChallengeFilter } from '@shared/models/challenge/challenge-filter';
import { IChallengePreview } from '@shared/models/challenge/challenge-preview';
import { IEditChallenge } from '@shared/models/challenge/edit-challenge';
import { INewChallenge } from '@shared/models/challenge/new-challenge';
import { ISortedModel } from '@shared/models/challenge/sorted-model';
import { ISuggestionSettings } from '@shared/models/challenge/suggestion-settings';
import { IChallengeLevel } from '@shared/models/challenge-level/challenge-level';
import { IStar } from '@shared/models/challenge-star/star';
import { ICodeRunRequest } from '@shared/models/code-run/code-run-request';
import { IPageSettings } from '@shared/models/page-settings';
import { setParams } from '@shared/utils/http-params.utils';
import { Observable } from 'rxjs';

@Injectable({
    providedIn: 'root',
})
export class ChallengeService {
    public challengesRoute = '/challenge';

    constructor(private httpService: HttpInternalService) {}

    public getChallenges(filter?: IChallengeFilter, page?: IPageSettings, sortingModel?: ISortedModel) {
        let httpParams = new HttpParams();

        httpParams = setParams<IChallengeFilter>(httpParams, filter);
        httpParams = setParams<IPageSettings>(httpParams, page);
        httpParams = setParams<ISortedModel>(httpParams, sortingModel);

        return this.httpService.getRequest<IChallengePreview[]>(this.challengesRoute, httpParams);
    }

    public getChallengeLevels(): Observable<IChallengeLevel[]> {
        return this.httpService.getRequest<IChallengeLevel[]>(`${this.challengesRoute}/levels`);
    }

    public getChallengeSuggestion(settings: ISuggestionSettings) {
        let httpParams = new HttpParams();

        httpParams = setParams<ISuggestionSettings>(httpParams, settings);

        return this.httpService.getRequest<IChallengePreview>(`${this.challengesRoute}/suggestion`, httpParams);
    }

    public getChallengeById(id: number): Observable<IChallenge> {
        return this.httpService.getRequest<IChallenge>(`${this.challengesRoute}/${id}`);
    }

    public updateStar(star: IStar): Observable<IChallengePreview> {
        return this.httpService.putRequest<IChallengePreview>(this.challengesRoute, star);
    }

    public runTests(request: ICodeRunRequest): Observable<void> {
        return this.httpService.postRequest<void>(`${this.challengesRoute}/test`, request);
    }

    public updateChallenge(challenge: IEditChallenge): Observable<IChallenge> {
        return this.httpService.putRequest<IChallenge>(`${this.challengesRoute}/edit`, challenge);
    }

    public createChallenge(challenge: INewChallenge): Observable<IChallenge> {
        return this.httpService.postRequest<IChallenge>(`${this.challengesRoute}`, challenge);
    }

    public deleteChallenge(id: number): Observable<void> {
        return this.httpService.deleteRequest(`${this.challengesRoute}/${id}`);
    }
}
