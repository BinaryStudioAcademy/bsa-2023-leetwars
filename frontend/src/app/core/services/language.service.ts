import { Injectable } from '@angular/core';
import { HttpInternalService } from '@core/services/http-internal.service';
import { Language } from '@shared/models/language/language';

@Injectable({
    providedIn: 'root',
})
export class LanguageService {
    public baseUrl = '/language';

    constructor(private httpService: HttpInternalService) { }

    public getLanguages() {
        return this.httpService.getRequest<Language[]>(this.baseUrl);
    }
}
