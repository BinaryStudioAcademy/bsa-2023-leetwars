using LeetWars.CodeAnalyzer.OpenAISettings.Interfaces;

namespace LeetWars.CodeAnalyzer.OpenAISettings
{
    public class OpenAiSettings : IOpenAiSettings
    {
        public string GetCodeAnalysisPrompt(string languageName, string codeListing) => 
            $"You are a software Architect, as a software architect for implementing high quality {languageName} application, " +
            "your goal is to analyze the code and  and provide overall quality mark (from 0 to 100) for this code. " +
            "Your answer must contains only percent of overall quality mark. Don't provide additional info, only a number." + 
            $"Please, start your answer with quality mark. Code listing: \n ${codeListing}";
    }
}
