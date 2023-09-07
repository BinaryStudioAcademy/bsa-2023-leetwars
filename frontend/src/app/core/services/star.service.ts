import { Injectable } from '@angular/core';
import { Star } from '@shared/models/challenge-star/star';

import { HttpInternalService } from './http-internal.service';

@Injectable({
    providedIn: 'root',
})
export class StarService {
    public baseUrl = '/stars';

    constructor(private httpService: HttpInternalService) {}

    public updateStar(star: Star) {
        return this.httpService.putRequest<Star>(this.baseUrl, star);
    }
}
