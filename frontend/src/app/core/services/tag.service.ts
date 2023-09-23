import { Injectable } from '@angular/core';
import { HttpInternalService } from '@core/services/http-internal.service';
import { ITag } from '@shared/models/tag/tag';

@Injectable({
    providedIn: 'root',
})
export class TagService {
    private baseUrl = '/tags';

    constructor(private httpService: HttpInternalService) { }

    public getTags() {
        return this.httpService.getRequest<ITag[]>(this.baseUrl);
    }
}
