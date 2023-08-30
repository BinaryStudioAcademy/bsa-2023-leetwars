/* eslint-disable no-empty-function */
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
    onChange: (value: string) => void = () => {};

    onTouchedFn: () => void = () => {};

    private _value = '';

    get value(): string {
        return this._value;
    }

    set value(v: string) {
        this._value = v;
        if (this.onChange) {
            this.onChange(this._value);
        }
    }

    registerOnChange(fn: (value: string) => void): void {
        this.onChange = fn;
        this.onChange(this._value);
    }

    registerOnTouched(fn: () => void): void {
        this.onTouchedFn = fn;
    }

    writeValue(value: string): void {
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

    onInputChange(model: string): void {
        this.InputValue = model;
        this.InputValueChange.emit(model);
    }

    togglePasswordVisibility(): void {
        this.InputType = this.InputType === 'password' ? 'text' : 'password';
        this.showPassword = !this.showPassword;
    }
}
