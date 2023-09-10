import { HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { HttpInternalService } from '@core/services/http-internal.service';
import { ApiResponse } from '@shared/models/api-response';
import { Challenge } from '@shared/models/challenge/challenge';
import { ChallengeFilter } from '@shared/models/challenge/challenge-filter';
import { ChallengePreview } from '@shared/models/challenge/challenge-preview';
import { SuggestionSettings } from '@shared/models/challenge/suggestion-settings';
import { CodeRunRequest } from '@shared/models/code-run/code-run-request';
import { PageSettings } from '@shared/models/page-settings';
import { setParams } from '@shared/utils/http-params.utils';
import { Observable } from 'rxjs';

@Injectable({
    providedIn: 'root',
})
export class ChallengeService {
    public challengesRoute = '/challenge';

    constructor(private httpService: HttpInternalService) { }

    public getChallenges(filter?: ChallengeFilter, page?: PageSettings) {
        let httpParams = new HttpParams();

        httpParams = setParams<ChallengeFilter>(httpParams, filter);
        httpParams = setParams<PageSettings>(httpParams, page);

        return this.httpService.getRequest<ChallengePreview[]>(this.challengesRoute, httpParams);
    }

    public getChallengeSuggestion(settings: SuggestionSettings) {
        let httpParams = new HttpParams();

        httpParams = setParams<SuggestionSettings>(httpParams, settings);

        return this.httpService.getRequest<ChallengePreview>(`${this.challengesRoute}/suggestion`, httpParams);
    }

    public getChallengeById(id: number): Observable<Challenge> {
        return this.httpService.getRequest<Challenge>(`${this.challengesRoute}/${id}`);
    }

    public postCode(request: CodeRunRequest): Observable<ApiResponse> {
        const id: number = request.challengeVersionId;
        const selectedLanguage: string = request.language

        return this.httpService.postRequest<ApiResponse>(`${this.challengesRoute}/${id}/${selectedLanguage}`, request)
    }
}
