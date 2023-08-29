import { Component, EventEmitter, Input, Output } from '@angular/core';

@Component({
    selector: 'app-custom-input[Identifier]',
    templateUrl: './custom-input.component.html',
    styleUrls: ['./custom-input.component.sass'],
})
export class CustomInputComponent {
    @Input() InputType: string = 'text';

    @Input() Identifier: string = 'text';

    @Input() Height: string = '64px';

    @Input() Width: string = '327px';

    @Input() Margin: string = '0 auto';

    @Input() FormTextHeight: string = '45px';

    @Input() InputValue?: string;

    @Input() InputLabel?: string;

    @Input() InputPlaceholder?: string;

    @Output() InputValueChange = new EventEmitter<string>();

    public showPassword = false;

    public onInputChange(model: string) {
        this.InputValue = model;
        this.InputValueChange.emit(model);
    }

    public togglePasswordVisibility() {
        this.InputType = this.InputType === 'password' ? 'text' : 'password';
        this.showPassword = !this.showPassword;
    }
}
