import { Injectable } from '@angular/core';
import { HttpInternalService } from '@core/services/http-internal.service';
import { Tag } from '@shared/models/tag/tag';

@Injectable({
    providedIn: 'root',
})
export class TagService {
    public baseUrl = '/tags';

    constructor(private httpService: HttpInternalService) { }

    public getTags() {
        return this.httpService.getRequest<Tag[]>(this.baseUrl);
    }
}