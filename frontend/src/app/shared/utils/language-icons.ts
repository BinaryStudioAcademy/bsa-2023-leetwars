const LANGUAGE_ICONS = [
    { name: 'html', url: '/assets/images/html.png' },
    { name: 'ruby', url: '/assets/images/ruby.png' },
    { name: 'javascript', url: '/assets/images/js.png' },
    { name: 'typescript', url: '/assets/images/js.png' },
];

const DEFAULT_URL = '/assets/images/html.png';

export function getLanguageIconUrl(languageName: string) {
    const item = LANGUAGE_ICONS.find(i => i.name === languageName.toLowerCase());

    if (item) {
        return item.url;
    }

    return DEFAULT_URL;
}
