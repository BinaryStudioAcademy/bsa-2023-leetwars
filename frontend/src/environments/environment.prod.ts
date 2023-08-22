import { secrets } from '@env/secrets';

export const environment = {
    production: true,
    coreUrl: '/api',
    notifierUrl: '/notifier',
    ...secrets,
};
