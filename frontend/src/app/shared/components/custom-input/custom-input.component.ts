import { Component, EventEmitter, Input, Output } from '@angular/core';

@Component({
    selector: 'app-custom-input',
    templateUrl: './custom-input.component.html',
    styleUrls: ['./custom-input.component.sass'],
})
export class CustomInputComponent {
    constructor() {}

    @Input() InputType: string = 'text';
    @Input() Identifier: string = 'text';
    @Input() Height: string;
    @Input() Width: string;
    @Input() InputValue?: string;
    @Input() InputLabel?: string;
    @Input() InputPlaceholder?: string;
    @Output() InputValueChange = new EventEmitter<string>();

  onInputChange(model: string)
  {
    this.InputValue = model;
    this.InputValueChange.emit(model);
  }
    


}
