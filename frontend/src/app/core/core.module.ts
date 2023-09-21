import { HTTP_INTERCEPTORS, HttpClientModule } from '@angular/common/http';
import { ErrorHandler, NgModule } from '@angular/core';

import { SharedModule } from '../shared/shared.module';

import { BaseComponent } from './base/base.component';
import { ErrorInterceptor } from './interceptors/error.interceptor';
import { JwtInterceptor } from './interceptors/jwt.interceptor';
import { GlobalErrorHandlerService } from './services/globalerrorhandler.service';

@NgModule({
    imports: [HttpClientModule, SharedModule],
    providers: [
        { provide: HTTP_INTERCEPTORS, useClass: JwtInterceptor, multi: true },
        { provide: HTTP_INTERCEPTORS, useClass: ErrorInterceptor, multi: true },
        { provide: ErrorHandler, useClass: GlobalErrorHandlerService },
    ],
    declarations: [BaseComponent],
})
export class CoreModule {}
