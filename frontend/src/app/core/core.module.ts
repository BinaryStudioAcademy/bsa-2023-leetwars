import { HTTP_INTERCEPTORS, HttpClientModule } from '@angular/common/http';
import { APP_INITIALIZER, ErrorHandler, NgModule } from '@angular/core';

import { SharedModule } from '../shared/shared.module';

import { BaseComponent } from './base/base.component';
import { ScrollComponent } from './base/scroll.component';
import { ErrorInterceptor } from './interceptors/error.interceptor';
import { JwtInterceptor } from './interceptors/jwt.interceptor';
import { AppInitService } from './services/app-init.service';
import { AuthService } from './services/auth.service';
import { GlobalErrorHandlerService } from './services/globalerrorhandler.service';

@NgModule({
    imports: [HttpClientModule, SharedModule],
    providers: [
        { provide: HTTP_INTERCEPTORS, useClass: JwtInterceptor, multi: true },
        { provide: HTTP_INTERCEPTORS, useClass: ErrorInterceptor, multi: true },
        { provide: ErrorHandler, useClass: GlobalErrorHandlerService },
        {
            provide: APP_INITIALIZER,
            useFactory: (appInitService: AppInitService) => () => appInitService.initializeApp(),
            deps: [AppInitService],
            multi: true,
        },
        AppInitService,
        AuthService,
    ],
    declarations: [BaseComponent, ScrollComponent],
})
export class CoreModule {}
