import { Component, Input } from '@angular/core';

@Component({
    selector: 'app-link-profile-button',
    templateUrl: './link-profile-button.component.html',
    styleUrls: ['./link-profile-button.component.sass'],
})
export class LinkProfileButtonComponent {
    @Input() buttonText: string = 'Click Me';
}
