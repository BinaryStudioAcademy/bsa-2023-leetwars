import { SimpleChanges } from '@angular/core';
import { FormGroup } from '@angular/forms';
import { CategoryType } from '@shared/enums/category-type';
import { ChallengeStep } from '@shared/enums/challenge-step';
import { NewChallenge } from '@shared/models/challenge/new-challenge';
import { NewChallengeVersion } from '@shared/models/challenge-version/new-challenge-version';
import { DropdownItem } from '@shared/models/dropdown-item';

export const steps = [
    { step: ChallengeStep.Question, isValid: false, checkValidation: false },
    { step: ChallengeStep.Solutions, isValid: false, checkValidation: false },
    { step: ChallengeStep.Testcases, isValid: false, checkValidation: false },
];

export function getStepIndex(step: ChallengeStep) {
    return steps.findIndex(s => s.step === step);
}

export function getStep(step: ChallengeStep) {
    return steps.find(s => s.step === step);
}

export function getStepChecking(stepType: ChallengeStep) {
    const step = getStep(stepType);

    if (step) {
        return step.checkValidation;
    }

    return false;
}

export function stepAllowed(stepIndex: number) {
    return steps.every((value, index) => {
        if (index < stepIndex) {
            steps[index].checkValidation = true;

            return value.isValid;
        }

        return true;
    });
}

export function getNewChallenge(): NewChallenge {
    return {
        title: '',
        instructions: '',
        category: CategoryType.Fundamentals,
        levelId: 0,
        level: { id: 0, name: '', skillLevel: 0, reward: 0 },
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

const DROPDOWN_TEMPLATES: DropdownItem[] = [
    { content: 'JavaScript', iconName: 'node-js' },
];

export function getDropdownItems(names: string[]): DropdownItem[] {
    return names.map<DropdownItem>(itemName => {
        const template = DROPDOWN_TEMPLATES.find(item => item.content.toLowerCase() === itemName.toLowerCase());

        if (template) {
            return template;
        }

        return { content: itemName };
    });
}

export function fillFormInputs(form: FormGroup, changes: SimpleChanges) {
    Object.keys(changes).forEach(changesKey => {
        const field = form.get(changesKey);

        if (field) {
            field.setValue(changes[changesKey].currentValue);
        }
    });
}
