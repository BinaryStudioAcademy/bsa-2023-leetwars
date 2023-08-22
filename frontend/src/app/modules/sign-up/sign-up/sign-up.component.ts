import { Component, OnInit } from '@angular/core';
import { faEyeSlash } from '@fortawesome/free-regular-svg-icons';

@Component({
    selector: 'app-sign-up',
    templateUrl: './sign-up.component.html',
    styleUrls: ['./sign-up.component.sass'],
})
export class SignUpComponent implements OnInit {
    faEyeSlash = faEyeSlash;

    constructor() {}

    ngOnInit(): void {}
}
