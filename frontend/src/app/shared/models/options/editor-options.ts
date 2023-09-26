export interface EditorOptions {
    language: string;
    theme: string;
    minimap: {
        isEnabled: boolean;
    };
    hasAutomaticLayout: boolean;
    hasShadows: boolean;
    wordWrap: boolean;
    lineNumbers: boolean;
    tabWidth: number;
    fontSize: number;
}
