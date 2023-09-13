import { HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { HttpInternalService } from '@core/services/http-internal.service';
import { ApiResponse } from '@shared/models/api-response';
import { IChallenge } from '@shared/models/challenge/challenge';
import { IChallengeFilter } from '@shared/models/challenge/challenge-filter';
import { IChallengePreview } from '@shared/models/challenge/challenge-preview';
import { INewChallenge } from '@shared/models/challenge/new-challenge';
import { ISuggestionSettings } from '@shared/models/challenge/suggestion-settings';
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

    public getChallenges(filter?: IChallengeFilter, page?: IPageSettings) {
        let httpParams = new HttpParams();

        httpParams = setParams<IChallengeFilter>(httpParams, filter);
        httpParams = setParams<IPageSettings>(httpParams, page);

        return this.httpService.getRequest<IChallengePreview[]>(this.challengesRoute, httpParams);
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

    public postCode(request: ICodeRunRequest): Observable<ApiResponse> {
        const id: number = request.challengeVersionId;
        const selectedLanguage: string = request.language;

        return this.httpService.postRequest<ApiResponse>(`${this.challengesRoute}/${id}/${selectedLanguage}`, request);
    }

    public createChallenge(challenge: INewChallenge): Observable<IChallenge> {
        return this.httpService.postRequest<IChallenge>(`${this.challengesRoute}`, challenge);
    }
}
