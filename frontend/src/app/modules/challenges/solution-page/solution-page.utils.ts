import { NavigationTabType } from '@shared/enums/navigation-tab-type';
import { NavigationTab } from '@shared/models/navigation-tab';

export const tabs: NavigationTab[] = [
    {
        type: NavigationTabType.Complete,
        active: true,
        disabled: false,
    },
    {
        type: NavigationTabType.Initial,
        active: false,
        disabled: false,
    },
    {
        type: NavigationTabType.Preloaded,
        active: false,
        disabled: false,
    },
];
