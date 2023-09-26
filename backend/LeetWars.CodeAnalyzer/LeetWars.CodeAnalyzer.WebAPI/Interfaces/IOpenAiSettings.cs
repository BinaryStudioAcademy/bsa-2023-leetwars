namespace LeetWars.CodeAnalyzer.Interfaces
{
    public interface IOpenAiSettings
    {
        string GetCodeAnalysisPrompt(string languageName, string codeListing);
    }
}
