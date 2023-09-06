const languageNameMapping: { [name: string]: string } = {
    'C#': 'csharp',
};

export function getEditorLanguageName(language: string) {
    return languageNameMapping[language] || language.toLowerCase();
}
