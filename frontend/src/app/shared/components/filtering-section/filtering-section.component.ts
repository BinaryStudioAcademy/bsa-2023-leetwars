import { Component } from '@angular/core';

@Component({
    selector: 'app-filtering-section',
    templateUrl: './filtering-section.component.html',
    styleUrls: ['./filtering-section.component.sass'],
})
export class FilteringSectionComponent {
    //TODO: Replace with real implementation
    public challengesList = ['nothing', 'to', 'be'];

    //TODO: Replace with real implementation
    public languagesList = ['HTML', 'C#', 'Java'];

    public statusesList = ['Approved & Beta', 'Approved', 'Beta'];

    public progressesList = ['All', 'Not completed', 'Completed', 'Not trained on'];

    //TODO: Replace with real implementation
    public tagsList = ['Algorithms', 'Strings', 'Data Types', 'Formatting', 'Logic'];
}
