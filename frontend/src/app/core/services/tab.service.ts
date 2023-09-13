import { Injectable } from '@angular/core';

@Injectable({
    providedIn: 'root',
})
export class TabService {
    private activeTabKey = 'activeTab';

    getActiveTab(): string | null {
        return localStorage.getItem(this.activeTabKey);
    }

    setActiveTab(tabRoute: string): void {
        localStorage.setItem(this.activeTabKey, tabRoute);
    }
}
