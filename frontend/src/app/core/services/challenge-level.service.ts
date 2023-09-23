import { Injectable } from '@angular/core';
import { HttpInternalService } from '@core/services/http-internal.service';
import { IChallengeLevel } from '@shared/models/challenge-level/challenge-level';

@Injectable({
    providedIn: 'root',
})
export class ChallengeLevelService {
    private baseUrl = '/challengelevel';

    constructor(private httpService: HttpInternalService) { }

    public getLevels() {
        return this.httpService.getRequest<IChallengeLevel[]>(this.baseUrl);
    }
}
