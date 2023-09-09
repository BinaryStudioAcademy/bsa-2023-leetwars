export const passwordPattern = '^(?!.*\\s)(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9]).{8,32}(?<!\\s)$';
export const latinOrCyrillicCharactersPattern = '^[a-zA-Zа-яА-ЯҐґІіЇїЄє0-9_]+(?:[-\\s][a-zA-Zа-яА-ЯҐґІіЇїЄє0-9_]+)*$';
export const emailPattern = '^[a-zA-Z0-9._-]{2,}@[a-zA-Z0-9.-]+[.][a-zA-Z]{2,4}$';
