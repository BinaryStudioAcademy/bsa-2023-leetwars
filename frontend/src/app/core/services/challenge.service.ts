import { HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { HttpInternalService } from '@core/services/http-internal.service';
import { ChallengeFilter } from '@shared/models/challenge/challenge-filter';
import { ChallengePreview } from '@shared/models/challenge/challenge-preview';
import { SuggestionSettings } from '@shared/models/challenge/suggestion-settings';
import { PageSettings } from '@shared/models/page-settings';
import { setParams } from '@shared/utils/http-params.utils';

@Injectable({
    providedIn: 'root',
})
export class ChallengeService {
    public baseUrl = '/challenge';

    constructor(private httpService: HttpInternalService) { }

    public getChallenges(filter?: ChallengeFilter, page?: PageSettings) {
        let httpParams = new HttpParams();

        httpParams = setParams<ChallengeFilter>(httpParams, filter);
        httpParams = setParams<PageSettings>(httpParams, page);

        return this.httpService.getRequest<ChallengePreview[]>(this.baseUrl, httpParams);
    }

    public getChallengeSuggestion(settings: SuggestionSettings) {
        let httpParams = new HttpParams();

        httpParams = setParams<SuggestionSettings>(httpParams, settings);

        return this.httpService.getRequest<ChallengePreview>(`${this.baseUrl}/suggestion`, httpParams);
    }
}
