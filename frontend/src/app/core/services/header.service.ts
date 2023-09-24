import { Injectable } from '@angular/core';

@Injectable({
    providedIn: 'root',
})
export class HeaderService {
    private showHeader: boolean = false;

    public getShowHeader() {
        return this.showHeader;
    }

    public setShowHeader(value: boolean) {
        this.showHeader = value;
    }
}
