const BASE_URL = '/assets/images/programming-languages';
const DEFAULT_URL = `${BASE_URL}/default_pl.png`;
const LANGUAGE_ICONS = [
    { name: 'html', url: 'html.png' },
    { name: 'ruby', url: 'ruby.png' },
    { name: 'javascript', url: 'js.png' },
    { name: 'typescript', url: 'ts.png' },
    { name: 'c#', url: 'csharp.png' },
    { name: 'python', url: 'python.png' },
];

function generateLanguageIconUrl(languageUrl: string) {
    return `${BASE_URL}/${languageUrl}`;
}

export function getLanguageIconUrl(languageName: string) {
    const icon = LANGUAGE_ICONS.find((li) => li.name.toLowerCase() === languageName.toLowerCase());

    if (icon) {
        return generateLanguageIconUrl(icon.url);
    }

    return DEFAULT_URL;
}
