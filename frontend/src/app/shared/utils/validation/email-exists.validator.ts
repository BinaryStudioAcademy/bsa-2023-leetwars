import { AbstractControl, AsyncValidatorFn } from '@angular/forms';
import { UserService } from '@core/services/user.service';
import { map } from 'rxjs';

export function emailExistsValidator(userService: UserService): AsyncValidatorFn {
    return (control: AbstractControl) =>
        userService.checkEmail(control.value).pipe(map((result) => (result ? { emailAlreadyExists: true } : null)));
}
