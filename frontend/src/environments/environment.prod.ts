import { firebaseSettings } from '@env/firebase-settings';

export const environment = {
    production: true,
    coreUrl: '/api',
    notifierUrl: '/notifier',
    codeAnylizerUrl: '/codeanalyzer',
    ...firebaseSettings,
};
