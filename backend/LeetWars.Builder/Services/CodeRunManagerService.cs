﻿using LeetWars.Builder.DTO;
using LeetWars.Builder.Interfaces;
using LeetWars.Builder.Models;

namespace LeetWars.Builder.Services
{
    public class CodeRunManagerService : ICodeRunManagerService
    {
        private readonly ISolutionRunnerService _solutionRunner;

        public CodeRunManagerService(ISolutionRunnerService solutionRunner)
        {
            _solutionRunner = solutionRunner;
        }

        public async Task<CodeRunResults> RunCodeAndTestsAsync(CodeRunRequest request)
        {
            string processName = request.UserId + "_" + request.ChallengeVersionId + "-testing";

            var testRunResults = await _solutionRunner.RunSolutionTestsAsync(new TestingContainerDataDto(processName, request.Language, request.UserCode, request.Tests ?? "", request.Preloaded ?? ""));

            return new CodeRunResults
            {
                ChallengeVersionId = request.ChallengeVersionId,
                Language = request.Language,
                IsBuilt = request.IsBuilt,
                TestRunResults = testRunResults
            };
        }
    }
}