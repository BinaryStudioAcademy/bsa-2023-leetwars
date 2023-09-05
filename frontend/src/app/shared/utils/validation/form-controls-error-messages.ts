import {
    emailMaxLength,
    passwordMaxLength,
    passwordMinLength,
    userNameMaxLength,
    userNameMinLength,
} from '@shared/utils/validation/form-control-validator-options';
import { ControlErrorMessages } from '@shared/utils/validation/validation-interfaces';

export const emailValidationErrorMessages: ControlErrorMessages = {
    required: 'Please enter your Email',
    email: 'Email format is incorrect. An example of the correct format: example@example.com',
    maxlength: `Email must not exceed ${emailMaxLength} characters`,
    noDotInDomain: 'Email format is incorrect. An example of the correct format: example@example.com',
};

export const usernameValidationErrorMessages: ControlErrorMessages = {
    required: 'Please enter your username',
    minlength: `Username must be at least ${userNameMinLength} characters`,
    maxlength: `Username must not exceed ${userNameMaxLength} characters`,
    pattern: 'Please enter your username in Latin. Allowed characters: letters, spaces, dashes',
};

export const passwordValidationErrorMessages: ControlErrorMessages = {
    required: 'Please enter your password',
    minlength: `Password must be at least ${passwordMinLength} characters`,
    maxlength: `Password must not exceed ${passwordMaxLength} characters`,
    pattern: 'Password must contain at least one uppercase letter, one lowercase letter, and one number',
};
