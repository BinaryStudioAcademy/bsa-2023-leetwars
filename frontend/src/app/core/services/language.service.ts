import { Injectable } from '@angular/core';
import { HttpInternalService } from '@core/services/http-internal.service';
import { ILanguage } from '@shared/models/language/language';

@Injectable({
    providedIn: 'root',
})
export class LanguageService {
    private baseUrl = '/language';

    constructor(private httpService: HttpInternalService) {}

    getLanguages() {
        return this.httpService.getRequest<ILanguage[]>(this.baseUrl);
    }
}
