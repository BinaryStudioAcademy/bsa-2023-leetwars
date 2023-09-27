import { Component, EventEmitter, forwardRef, Input, OnInit, Output } from '@angular/core';
import { ControlValueAccessor, NG_VALUE_ACCESSOR } from '@angular/forms';
import { SecondsConstants } from '@shared/constants/second-constants';
import { debounceTime, Subject } from 'rxjs';

/* eslint-disable no-empty-function */
/* eslint-disable no-use-before-define */
@Component({
    selector: 'app-custom-input[Identifier]',
    templateUrl: './custom-input.component.html',
    styleUrls: ['./custom-input.component.sass'],
    providers: [
        {
            provide: NG_VALUE_ACCESSOR,
            multi: true,
            useExisting: forwardRef(() => CustomInputComponent),
        },
    ],
})
export class CustomInputComponent implements ControlValueAccessor, OnInit {
    @Input() InputType: string = 'text';

    @Input() Identifier: string = 'text';

    @Input() Height: string = '64px';

    @Input() Width: string = '327px';

    @Input() FormTextHeight: string = '45px';

    @Input() IsForgetPassword: boolean = false;

    @Input() InputValue?: string;

    @Input() InputLabel?: string;

    @Input() InputPlaceholder?: string;

    @Input() checked: boolean = false;

    @Input() disabled: boolean;

    @Output() InputValueChange = new EventEmitter<string>();

    showPassword = false;

    private _value = '';

    private searchSubject = new Subject<string>();

    ngOnInit(): void {
        this.searchSubject.pipe(debounceTime(SecondsConstants.Delay)).subscribe((model) => {
            this.InputValue = model;
            this.InputValueChange.emit(model);
        });
    }

    onChange: (value: string) => void = () => {};

    onTouchedFn: () => void = () => {};

    get value(): string {
        return this._value;
    }

    set value(v: string) {
        this._value = v;
        if (this.onChange) {
            this.onChange(this._value);
        }
    }

    registerOnChange(fn: (value: string) => void) {
        this.onChange = fn;
        this.onChange(this._value);
    }

    registerOnTouched(fn: () => void) {
        this.onTouchedFn = fn;
    }

    writeValue(value: string) {
        this.value = value;
    }

    onInputChange(model: string) {
        this.searchSubject.next(model);
    }

    togglePasswordVisibility() {
        this.InputType = this.InputType === 'password' ? 'text' : 'password';
        this.showPassword = !this.showPassword;
    }

    onPasswordKeyDown(event: KeyboardEvent) {
        if (event.key === 'Enter') {
            event.preventDefault();
        }
    }
}
