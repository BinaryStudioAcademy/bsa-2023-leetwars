using LeetWars.CodeAnalyzer.Interfaces;
using LeetWars.Core.Common.DTO.Challenge;
using LeetWars.Core.Common.DTO.ChallengeRequest;

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

        public string GetChallengePrompt(ChallengeGenerateRequestDto challengeGenerateRequestDto) =>
             $"You are a full-stack developer. As a {challengeGenerateRequestDto.Language} full-stack developer, your goal is to create a challenge task with the following name: {challengeGenerateRequestDto.Title}, in the following category: {challengeGenerateRequestDto.Category}, with the following tags: {challengeGenerateRequestDto.Tags}, and at the following level: {challengeGenerateRequestDto.Level}." +
            "Describe a task that matches these properties in the field - Description" +
            "Then create a complete solution based on description in the field - CompleteSolution" +
            "Then create an initial solution based on description in the field - InitialSolution" +
            "Then create a test cases for the complete solution and initial solution in the field - TestCases" +
            "Then create an example of test cases for the complete solution and initial solution in the field - ExampleTestCases" +
            "And give me the information in the form of a Json object with the following fields string Description string CompleteSolution string InitialSolution string TestCases string ExampleTestCases";

    }
}
