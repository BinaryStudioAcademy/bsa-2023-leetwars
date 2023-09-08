import { NgxMonacoEditorConfig } from 'ngx-monaco-editor-v2';

export const monacoConfig: NgxMonacoEditorConfig = {
    baseUrl: '/assets',
    defaultOptions: { scrollBeyondLastLine: false },
    onMonacoLoad: () => {
        // eslint-disable-next-line @typescript-eslint/no-explicit-any
        (<any>window).monaco.editor.defineTheme('custom-theme', {
            base: 'vs-dark',
            inherit: true,
            rules: [],
            colors: {
                'editor.background': '#222327',
            },
        });
    },
};
