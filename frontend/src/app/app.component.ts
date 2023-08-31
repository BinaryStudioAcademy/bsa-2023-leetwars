import { Component } from '@angular/core';
import { NavigationCancel, NavigationEnd, NavigationError, NavigationStart, Router } from '@angular/router';
import { SpinnerService } from '@core/services/spinner.service';

@Component({
    selector: 'app-root',
    templateUrl: './app.component.html',
})
export class AppComponent {
    isAuthPage: boolean;

    constructor(private router: Router, private spinner: SpinnerService) {
        this.listenRouter();
    }

    private listenRouter() {
        this.router.events.subscribe((event) => {
            if (event instanceof NavigationStart) {
                this.spinner.show();
            }
            if (
                event instanceof NavigationEnd ||
                event instanceof NavigationCancel ||
                event instanceof NavigationError
            ) {
                this.spinner.hide();
            }
            if (event instanceof NavigationStart) {
                this.isAuthPage = event.url.startsWith('/auth') || event.url === '/';
            }
        });
    }
}
