import { StepData } from '@modules/challenges/challenge-creation/step-data';
import { CategoryType } from '@shared/enums/category-type';
import { ChallengeStep } from '@shared/enums/challenge-step';
import { languageNameMap } from '@shared/mappings/language-map';
import { IChallenge } from '@shared/models/challenge/challenge';
import { IEditChallenge } from '@shared/models/challenge/edit-challenge';
import { INewChallenge } from '@shared/models/challenge/new-challenge';
import { INewChallengeVersion } from '@shared/models/challenge-version/new-challenge-version';
import { IDropdownItem } from '@shared/models/dropdown-item';
import { EditorOptions } from '@shared/models/options/editor-options';
import { getLanguageIconUrl } from '@shared/utils/language-icons';

export function getInitStepsData(isValid: boolean = false): StepData[] {
    return [
        {
            step: ChallengeStep.Question,
            isValid,
            checkValidation: false,
            requiredSteps: [],
        },
        {
            step: ChallengeStep.Solutions,
            isValid,
            checkValidation: false,
            requiredSteps: [ChallengeStep.Question],
        },
        {
            step: ChallengeStep.Testcases,
            isValid,
            checkValidation: false,
            requiredSteps: [ChallengeStep.Question, ChallengeStep.Solutions],
        },
    ];
}

export function getStepData(steps: StepData[], stepType: ChallengeStep) {
    return steps.find((s) => s.step === stepType);
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

    return stepsData.every((checkedStep) => {
        if (stepData.requiredSteps.includes(checkedStep.step)) {
            return checkedStep.isValid;
        }

        return true;
    });
}

export function showValidationErrorsForAllSteps(stepsData: StepData[]) {
    return stepsData.map((s) => ({
        ...s,
        checkValidation: true,
    }));
}

export function showValidationErrorsForRequiredSteps(stepsData: StepData[], step: ChallengeStep) {
    const stepData = getStepData(stepsData, step);

    if (!stepData) {
        return stepsData;
    }

    return stepsData.map((checkedStep) => {
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

export function getNewChallenge(): INewChallenge {
    return {
        title: '',
        instructions: '',
        category: CategoryType.Fundamentals,
        levelId: 0,
        tags: [],
        versions: [],
    };
}

export function getNewChallengeVersion(): INewChallengeVersion {
    return {
        languageId: 0,
        initialSolution: '',
        completeSolution: '',
        preloadedCode: '',
        testCases: '',
        exampleTestCases: '',
    };
}

export function prepareChallengeDto(challenge: INewChallenge): INewChallenge {
    return {
        ...challenge,
        levelId: challenge.level?.id ?? 0,
        versions: challenge.versions.filter(
            (v) => v.languageId && v.completeSolution && v.initialSolution && v.testCases && v.exampleTestCases,
        ),
    };
}

export function getDropdownItems(names: string[]): IDropdownItem[] {
    return names.map<IDropdownItem>((itemName) => ({ content: itemName, icon: getLanguageIconUrl(itemName) }));
}

export function mapLanguageName(language: string): string {
    return languageNameMap.get(language) || language.toLowerCase();
}

export const editorOptions: EditorOptions = {
    theme: 'vs-dark',
    language: '',
    minimap: { enabled: false },
    automaticLayout: true,
    useShadows: false,
    wordWrap: 'on',
    lineNumbers: 'on',
};

export function mapChallengeToEditChallenge(challenge: IChallenge): IEditChallenge {
    return {
        id: challenge.id,
        createdBy: challenge.createdBy!,
        title: challenge.title,
        instructions: challenge.instructions,
        levelId: challenge.levelId,
        level: challenge.level,
        category: challenge.category,
        tags: challenge.tags,
        versions: challenge.versions.map((version) => ({
            id: version.id,
            createdAt: version.createdAt.toString(),
            languageId: version.languageId,
            initialSolution: version.initialSolution,
            completeSolution: version.completeSolution,
            preloadedCode: version.preloadedCode,
            testCases: version.testCases,
            exampleTestCases: version.exampleTestCases,
        })),
    };
}
