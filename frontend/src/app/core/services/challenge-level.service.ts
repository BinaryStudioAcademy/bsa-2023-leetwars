import { Injectable } from '@angular/core';
import { HttpInternalService } from '@core/services/http-internal.service';
import { ChallengeLevel } from '@shared/models/challenge-level/challenge-level';

@Injectable({
    providedIn: 'root',
})
export class ChallengeLevelService {
    public baseUrl = '/challengelevel';

    constructor(private httpService: HttpInternalService) { }

    public getLevels() {
        return this.httpService.getRequest<ChallengeLevel[]>(this.baseUrl);
    }
}
