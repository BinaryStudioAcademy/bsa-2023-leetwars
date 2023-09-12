import { NavigationTabType } from '@shared/enums/navigation-tab-type';
import { NavigationTab } from '@shared/models/navigation-tab';

export const tabs: NavigationTab[] = [
    {
        type: NavigationTabType.TestCases,
        active: true,
        disabled: false,
    },
    {
        type: NavigationTabType.ExampleTestCases,
        active: false,
        disabled: false,
    },
];
