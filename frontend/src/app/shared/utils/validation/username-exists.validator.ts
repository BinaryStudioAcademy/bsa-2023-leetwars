import { AbstractControl, AsyncValidatorFn } from '@angular/forms';
import { UserService } from '@core/services/user.service';
import { map } from 'rxjs';

export function usernameExistsValidator(userService: UserService): AsyncValidatorFn {
    return (control: AbstractControl) =>
        userService
            .checkUserName(control.value)
            .pipe(map((result) => (result ? { usernameAlreadyExists: true } : null)));
}
