import { Injectable } from '@angular/core';
import { HttpInternalService } from '@core/services/http-internal.service';
import { ILanguage } from '@shared/models/language/language';

@Injectable({
    providedIn: 'root',
})
export class LanguageService {
    public baseUrl = '/language';

    constructor(private httpService: HttpInternalService) { }

    public getLanguages() {
        return this.httpService.getRequest<ILanguage[]>(this.baseUrl);
    }
}
