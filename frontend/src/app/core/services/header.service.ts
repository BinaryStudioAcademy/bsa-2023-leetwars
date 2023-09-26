import { Injectable } from '@angular/core';

@Injectable({
    providedIn: 'root',
})
export class HeaderService {
    private showHeader: boolean = false;

    getShowHeader() {
        return this.showHeader;
    }

    setShowHeader(value: boolean) {
        this.showHeader = value;
    }
}
