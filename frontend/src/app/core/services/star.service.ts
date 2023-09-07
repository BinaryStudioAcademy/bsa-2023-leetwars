import { Injectable } from '@angular/core';
import { Star } from '@shared/models/challenge-star/star';

import { HttpInternalService } from './http-internal.service';

@Injectable({
    providedIn: 'root',
})
export class StarService {
    public baseUrl = '/stars';

    constructor(private httpService: HttpInternalService) { }

    public getTags() {
        return this.httpService.getRequest<Star[]>(this.baseUrl);
    }
}
