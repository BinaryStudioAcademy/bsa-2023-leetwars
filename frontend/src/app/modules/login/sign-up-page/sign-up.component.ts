import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
    selector: 'app-sign-up',
    templateUrl: './sign-up.component.html',
    styleUrls: ['./sign-up.component.sass'],
})
export class SignUpComponent implements OnInit {
    public registrationForm: FormGroup;

    constructor(private fb: FormBuilder) {}

    public ngOnInit() {
        //TODO: Add validations to fields
        this.registrationForm = this.fb.group({
            email: ['', [Validators.required, Validators.email]],
            username: ['', [Validators.required]],
            password: ['', [Validators.required]],
        });
    }
}
