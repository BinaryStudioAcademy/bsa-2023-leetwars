import { Component } from '@angular/core';
import { NavigationCancel, NavigationEnd, NavigationError, NavigationStart, Router, RoutesRecognized } from '@angular/router';
import { SpinnerService } from '@core/services/spinner.service';

@Component({
    selector: 'app-root',
    templateUrl: './app.component.html',
})
export class AppComponent {
    isAuthPage: boolean;

    isRouteNotFound: boolean;

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
            if (event instanceof RoutesRecognized) {
                const route = event.state.root.firstChild;

                if (route) {
                    this.isRouteNotFound = route.routeConfig === null;
                }
            }

            if (event instanceof NavigationStart) {
                this.isAuthPage = event.url.startsWith('/auth') || event.url === '/';
            }
        });
    }
}
