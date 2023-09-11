import { AuditEntity } from '../common/audit-entity/audit-entity';

export interface Badge extends AuditEntity<number> {
    name: string;
    icon: string;
}

export type SlideInfo = {
    badge: Badge;
    isActive: boolean;
};
