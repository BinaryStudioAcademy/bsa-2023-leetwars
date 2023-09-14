using LeetWars.CodeAnalyzer.Interfaces;

namespace LeetWars.CodeAnalyzer.OpenAISettings
{
    public class OpenAiSettings : IOpenAiSettings
    {
        public string GetCodeAnalysisPrompt(string languageName, string codeListing) => 
            $"You are a software Architect, as a software architect for implementing high quality {languageName} application, " +
            "your goal is to analyze the code and provide overall quality mark (from 0 to 100) for this code. " +
            "Give 20 marks for functionality of this code. Code must build and run. " +
            "Give 20 marks for code purity. Code must follow SOLID principles, DRY, KISS, etc. " +
            "Give 10 marks for error handling. Code must throw exceptions when it needs or handle them." +
            "Give 10 marks for security. Code must be secure from injections, etc." +
            "Give 10 marks for readbility. Code must not have magic numbers or strings." +
            "Give 10 marks for naming convention. Code must follow name conventions depending on the programming language. " +
            "Give 10 marks for documentation and useful comments. Code must not have useless comments, TODO statements, etc. " +
            "Give 10 marks for formatting. Code must not have superfluous spaces or code in one string, etc." +
            "Your answer must contain only percent of overall quality mark. (Without any text and '%' symbol). " +
            "Don't provide additional info, only a number." + 
            $"Code listing: \n ${codeListing}";
    }
}
