import { FormGroup } from '@angular/forms';
import {
    challengeDescriptionValidationErrorMessages,
    challengeLevelValidationErrorMessages,
    challengeNameValidationErrorMessages,
    challengeTagsValidationErrorMessages,
    emailValidationErrorMessages,
    firebaseValidationErrorMessages,
    fontSizeValidationErrorMessages,
    passwordValidationErrorMessages,
    tabSizeValidationErrorMessages,
    usernameValidationErrorMessages,
} from '@shared/utils/validation/form-controls-error-messages';
import { ControlErrorMessages } from '@shared/utils/validation/validation-interfaces';

const controlErrorMessagesMap: { [key: string]: ControlErrorMessages } = {
    email: emailValidationErrorMessages,
    username: usernameValidationErrorMessages,
    password: passwordValidationErrorMessages,
    name: challengeNameValidationErrorMessages,
    description: challengeDescriptionValidationErrorMessages,
    level: challengeLevelValidationErrorMessages,
    tags: challengeTagsValidationErrorMessages,
    tabSize: tabSizeValidationErrorMessages,
    fontSize: fontSizeValidationErrorMessages,
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

export function getFirebaseErrorMessage(errorCode: string): string | null {
    switch (errorCode) {
        case 'auth/email-already-in-use':
            return firebaseValidationErrorMessages.emailAlreadyInUse;

        case 'auth/account-exists-with-different-credential':
            return firebaseValidationErrorMessages.differentCredential;

        default:
            return null;
    }
}
