import { environment } from '@env/environment';
import { BaseHttpInternalService } from './base-http-internal.service';
import { IChallengeGenerateRequest } from '@shared/models/challenge-generate/challenge-generate-request';
import { IChallengeGenerateResponse } from '@shared/models/challenge-generate/challenge-generate-response';
import { Observable } from 'rxjs';
import { Injectable } from '@angular/core';

@Injectable({ providedIn: 'root' })
export class CodeAnylizerHttpService extends BaseHttpInternalService {
    public baseUrl: string = environment.codeAnylizerUrl;

    public generateChallenge(challengeGenerateRequest: IChallengeGenerateRequest): Observable<IChallengeGenerateResponse> {
        return this.postRequest<IChallengeGenerateResponse>(`/generateChallenge`, challengeGenerateRequest);
    }
    
}