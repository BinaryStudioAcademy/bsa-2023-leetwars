import { Component } from '@angular/core';
import {
    NavigationCancel,
    NavigationEnd,
    NavigationError,
    NavigationStart,
    Router,
    RoutesRecognized,
} from '@angular/router';
import { SpinnerService } from '@core/services/spinner.service';

@Component({
    selector: 'app-root',
    templateUrl: './app.component.html',
})
export class AppComponent {
    isWithoutHeaderPage: boolean;

    isRouteFound: boolean;

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
                    const isFallbackRoute = route.routeConfig?.path === '**' && route.routeConfig?.pathMatch === 'full';

                    this.isRouteFound = !isFallbackRoute;
                }
            }

            if (event instanceof NavigationStart) {
                this.isWithoutHeaderPage =
                    event.url.startsWith('/auth') || event.url.startsWith('/challenges') || event.url === '/';
            }
        });
    }
}
