import { ChallengeProgress } from '@shared/enums/challenge-progress';
import { ChallengeStatus } from '@shared/enums/challenge-status';

export const PROGRESS_NAMES_MAP = [
    { state: undefined, name: 'All' },
    { state: ChallengeProgress.Started, name: 'Not completed', id: 1 },
    { state: ChallengeProgress.Completed, name: 'Completed', id: 2 },
    { state: ChallengeProgress.NotStarted, name: 'Not trained on', id: 0 },
];

export const STATUS_NAMES_MAP = [
    { status: undefined, name: 'Approved & Beta' },
    { status: ChallengeStatus.Approved, name: 'Approved' },
    { status: ChallengeStatus.Beta, name: 'Beta' },
];
