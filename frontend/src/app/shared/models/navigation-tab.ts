import { NavigationTabType } from '@shared/enums/navigation-tab-type';

export interface NavigationTab {
    type: NavigationTabType;
    active: boolean;
    disabled: boolean;
}
