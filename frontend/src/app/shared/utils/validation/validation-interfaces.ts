export interface ControlErrorMessages {
    [key: string]: string | undefined;
    required: string;
    minlength?: string;
    maxlength?: string;
    pattern?: string;
    email?: string;
}
