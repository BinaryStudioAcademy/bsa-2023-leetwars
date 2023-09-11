import { StepData } from '@modules/challenges/challenge-creation/step-data';
import { CategoryType } from '@shared/enums/category-type';
import { ChallengeStep } from '@shared/enums/challenge-step';
import { NewChallenge } from '@shared/models/challenge/new-challenge';
import { NewChallengeVersion } from '@shared/models/challenge-version/new-challenge-version';
import { DropdownItem } from '@shared/models/dropdown-item';
import { getLanguageIconUrl } from '@shared/utils/language-icons';

export function getInitStepsData(): StepData[] {
    return [
        {
            step: ChallengeStep.Question,
            isValid: false,
            checkValidation: false,
            requiredSteps: [],
        },
        {
            step: ChallengeStep.Solutions,
            isValid: false,
            checkValidation: false,
            requiredSteps: [ChallengeStep.Question],
        },
        {
            step: ChallengeStep.Testcases,
            isValid: false,
            checkValidation: false,
            requiredSteps: [ChallengeStep.Question, ChallengeStep.Solutions],
        },
    ];
}

export function getStepData(steps: StepData[], stepType: ChallengeStep) {
    return steps.find(s => s.step === stepType);
}

export function getStepChecking(stepsData: StepData[], step: ChallengeStep) {
    const stepData = getStepData(stepsData, step);

    if (!stepData) {
        return false;
    }

    return stepData.checkValidation;
}

export function stepIsAllowed(stepsData: StepData[], step: ChallengeStep) {
    const stepData = getStepData(stepsData, step);

    if (!stepData) {
        return false;
    }

    return stepsData.every(checkedStep => {
        if (stepData.requiredSteps.includes(checkedStep.step)) {
            return checkedStep.isValid;
        }

        return true;
    });
}

export function showValidationErrorsForAllSteps(stepsData: StepData[]) {
    return stepsData.map(s => ({
        ...s,
        checkValidation: true,
    }));
}
export function showValidationErrorsForRequiredSteps(stepsData: StepData[], step: ChallengeStep) {
    const stepData = getStepData(stepsData, step);

    if (!stepData) {
        return stepsData;
    }

    return stepsData.map(checkedStep => {
        if (stepData.requiredSteps.includes(checkedStep.step)) {
            return {
                ...checkedStep,
                checkValidation: true,
            };
        }

        return { ...checkedStep };
    });
}

export function checkAllStepsIsValid(stepsData: StepData[]) {
    return stepsData.every((checkedStep) => checkedStep.isValid);
}

export function getNewChallenge(): NewChallenge {
    return {
        title: '',
        instructions: '',
        category: CategoryType.Fundamentals,
        levelId: 0,
        tags: [],
        versions: [],
    };
}

export function getNewChallengeVersion(): NewChallengeVersion {
    return {
        languageId: 0,
        initialSolution: '',
        completeSolution: '',
        preloadedCode: '',
        testCases: '',
        exampleTestCases: '',
    };
}

export function prepareChallengeDto(challenge: NewChallenge): NewChallenge {
    return {
        ...challenge,
        levelId: challenge.level?.id ?? 0,
        versions: challenge.versions.filter(v =>
            v.languageId && v.completeSolution && v.initialSolution && v.testCases && v.exampleTestCases),
    };
}

export function getDropdownItems(names: string[]): DropdownItem[] {
    return names.map<DropdownItem>(itemName => ({ content: itemName, icon: getLanguageIconUrl(itemName) }));
}
