import { ChallengeProgress } from '@shared/enums/challenge-progress';
import { ChallengeStatus } from '@shared/enums/challenge-status';
import { SortingOrder } from '@shared/enums/sorting-order';
import { SortingProperty } from '@shared/enums/sorting-property';
import { ISortedModel } from '@shared/models/challenge/sorted-model';

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

export const SORTING_PROPERTIES: ISortedModel[] = [
    { property: SortingProperty.Title, order: SortingOrder.Ascending, label: 'Name A-Z' },
    { property: SortingProperty.Title, order: SortingOrder.Descending, label: 'Name Z-A' },
    { property: SortingProperty.Level, order: SortingOrder.Ascending, label: 'Easy' },
    { property: SortingProperty.Level, order: SortingOrder.Descending, label: 'Extreme' },
    { property: SortingProperty.Stars, order: SortingOrder.Descending, label: 'Popular' },
    { property: SortingProperty.Stars, order: SortingOrder.Ascending, label: 'Unpopular' },
    { property: SortingProperty.CreatedAt, order: SortingOrder.Descending, label: 'Newest' },
    { property: SortingProperty.CreatedAt, order: SortingOrder.Ascending, label: 'Oldest' },
];
