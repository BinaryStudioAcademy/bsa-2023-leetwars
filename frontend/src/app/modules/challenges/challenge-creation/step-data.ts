import { ChallengeStep } from '@shared/enums/challenge-step';

export interface StepData {
    step: ChallengeStep,
    requiredSteps: ChallengeStep[],
    isValid: boolean,
    checkValidation: boolean
}
