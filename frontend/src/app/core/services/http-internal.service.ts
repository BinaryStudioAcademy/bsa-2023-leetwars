import { environment } from '@env/environment';
import { BaseHttpInternalService } from './base-http-internal.service';
import { Injectable } from '@angular/core';

@Injectable({ providedIn: 'root' })
export class HttpInternalService extends BaseHttpInternalService {
    public baseUrl: string = environment.coreUrl; 
    
}
