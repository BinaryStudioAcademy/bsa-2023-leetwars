import { AbstractControl, ValidationErrors, ValidatorFn } from '@angular/forms';

export function createCompareValidator(controlOne: AbstractControl, controlTwo: AbstractControl): ValidatorFn {
    return (): ValidationErrors | null => (controlOne.value !== controlTwo.value ? { passwordMismatch: true } : null);
}
