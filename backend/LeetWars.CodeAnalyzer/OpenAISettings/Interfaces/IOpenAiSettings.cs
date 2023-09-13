namespace LeetWars.CodeAnalyzer.OpenAISettings.Interfaces
{
    public interface IOpenAiSettings
    {
        string GetCodeAnalysisPrompt(string languageName, string codeListing);
    }
}
