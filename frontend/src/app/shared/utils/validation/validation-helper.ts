import { AbstractControl, FormGroup, ValidationErrors } from '@angular/forms';
import {
    emailValidationErrorMessages,
    passwordValidationErrorMessages,
    usernameValidationErrorMessages,
} from '@shared/utils/validation/form-controls-error-messages';
import { ControlErrorMessages } from '@shared/utils/validation/validation-interfaces';

import { emailDomainPattern } from './regex-patterns';

const controlErrorMessagesMap: { [key: string]: ControlErrorMessages } = {
    email: emailValidationErrorMessages,
    username: usernameValidationErrorMessages,
    password: passwordValidationErrorMessages,
};

export function getErrorMessage(formControlName: string, form: FormGroup): string | null {
    const control = form.get(formControlName);
    const errors = Object.keys(control?.errors || {});

    if (errors.length > 0) {
        const controlErrorMessages = controlErrorMessagesMap[formControlName];

        return controlErrorMessages[errors[0]] || null;
    }

    return null;
}

export function emailWithDotValidator(control: AbstractControl): ValidationErrors | null {
    const email = control.value as string;

    if (email && emailDomainPattern.test(email)) {
        return null;
    }

    return { noDotInDomain: true };
}
