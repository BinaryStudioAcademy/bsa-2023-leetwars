using LeetWars.CodeAnalyzer.Interfaces;
using LeetWars.Core.Common.DTO.ChallengeRequest;
using LeetWars.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;

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

        public string GetChallengePrompt(ChallengeGenerateRequestDto challengeGenerateRequestDto) {
            var testFramework = challengeGenerateRequestDto.Language.Name == "Javascript" ? "Mocha" : "NUnit";
            return @$"You are a software engineer.As a {challengeGenerateRequestDto.Language.Name} developer, your goal is to
            create a {challengeGenerateRequestDto.Language.Name} programming challenge task with the following name: {challengeGenerateRequestDto.Title}
            Challenge programming language should be {challengeGenerateRequestDto.Language.Name}.
            Challenge category should be {challengeGenerateRequestDto.Category};
            Challenge topic should be related to {string.Join(", ", challengeGenerateRequestDto.Tags.Select(t => t.Name))};
            Challenge complexity should be {challengeGenerateRequestDto.Level.SkillLevel}.
            Describe a task that matches these requirements in the field called Description;
            Then create a complete solution based on description and put it in the field called CompleteSolution;
            Then create a placeholder where the code needs to be implemented by the challenge taker and put it in the field called InitialSolution;
            Then create tests using {testFramework} Framework that will verify that code in field CompleteSolution is correct and put them in the field called Tests
            Then create get a subset of tests in field Tests and put them in the field called TestsSubset
            And give me the result in the form of a JSON object, example of JSON object:
            {{ 
                ""Description"": "" "",
                ""CompleteSolution"": "" "",
                ""InitialSolution"": "" "",
                ""Tests"": "" "",
                ""TestsSubset"": "" "",
            }}
            ";}

    }
}
