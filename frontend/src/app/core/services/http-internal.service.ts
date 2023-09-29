import { Injectable } from '@angular/core';
import { environment } from '@env/environment';

import { BaseHttpInternalService } from './base-http-internal.service';

@Injectable({ providedIn: 'root' })
export class HttpInternalService extends BaseHttpInternalService {
    public baseUrl: string = environment.coreUrl;
}
