import { FormGroup } from '@angular/forms';
import {
    emailValidationErrorMessages,
    passwordValidationErrorMessages,
    usernameValidationErrorMessages,
} from '@shared/utils/validation/form-controls-error-messages';
import { ControlErrorMessages } from '@shared/utils/validation/validation-interfaces';

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
