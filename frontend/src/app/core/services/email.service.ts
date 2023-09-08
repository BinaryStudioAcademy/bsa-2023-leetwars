import { Injectable } from '@angular/core';
import { Mail } from '@shared/models/email/email';

import { HttpInternalService } from './http-internal.service';

@Injectable({
    providedIn: 'root',
})
export class EmailService {
    public baseUrl: string = 'http://localhost:5080/emailer';

    constructor(private httpService: HttpInternalService) {}

    public sendEmail(mail: Mail) {
        return this.httpService.postRequest(`${this.baseUrl}/sendEmail`, mail).subscribe();
    }
}
