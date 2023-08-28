/* eslint-disable no-empty-function */
/* eslint-disable @typescript-eslint/no-explicit-any */
/* eslint-disable no-use-before-define */
import { Component, EventEmitter, forwardRef, Input, Output } from '@angular/core';
import { ControlValueAccessor, NG_VALUE_ACCESSOR } from '@angular/forms';

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
export class CustomInputComponent implements ControlValueAccessor {
    onChange: any = () => {};

    onTouchedFn = () => {};

    private _value = '';

    get value() {
        return this._value;
    }

    set value(v) {
        this._value = v;
        if (this.onChange) {
            this.onChange(this._value);
        }
    }

    registerOnChange(fn: any): void {
        this.onChange = fn;
        this.onChange(this._value);
    }

    registerOnTouched(fn: any): void {
        this.onTouchedFn = fn;
    }

    writeValue(value: any): void {
        this.value = value;
    }

    @Input() InputType: string = 'text';

    @Input() Identifier: string = 'text';

    @Input() Height: string = '64px';

    @Input() Width: string = '327px';

    @Input() FormTextHeight: string = '45px';

    @Input() InputValue?: string;

    @Input() InputLabel?: string;

    @Input() InputPlaceholder?: string;

    @Output() InputValueChange = new EventEmitter<string>();

    showPassword = false;

    onInputChange(model: string) {
        this.InputValue = model;
        this.InputValueChange.emit(model);
    }

    togglePasswordVisibility() {
        this.InputType = this.InputType === 'password' ? 'text' : 'password';
        this.showPassword = !this.showPassword;
    }
}
