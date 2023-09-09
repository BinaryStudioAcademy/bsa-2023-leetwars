import { Injectable } from '@angular/core';

@Injectable({
    providedIn: 'root',
})
export class HeaderService {
    private showHeader: boolean = true;

    setShowHeader(value: boolean) {
        this.showHeader = value;
    }

    getShowHeader() {
        return this.showHeader;
    }
}
