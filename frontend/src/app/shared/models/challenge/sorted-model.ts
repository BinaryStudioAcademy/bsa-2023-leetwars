import { SortingOrder } from '@shared/enums/sorting-order';
import { SortingProperty } from '@shared/enums/sorting-property';

export interface ISortedModel {

    property: SortingProperty,
    order: SortingOrder,
    label?: string

}
