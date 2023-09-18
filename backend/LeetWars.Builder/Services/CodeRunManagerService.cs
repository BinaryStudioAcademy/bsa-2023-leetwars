using LeetWars.Builder.DTO;
using LeetWars.Builder.Helpers.BuildResultReader;
using LeetWars.Builder.Interfaces;
using LeetWars.Builder.Models;

namespace LeetWars.Builder.Services
{
    public class CodeRunManagerService : ICodeRunManagerService
    {
        private readonly ISolutionRunnerService _solutionRunner;
        private readonly BuildResultReader _buildResultBuilder = new();

        public CodeRunManagerService(ISolutionRunnerService solutionRunner)
        {
            _solutionRunner = solutionRunner;
        }

        public async Task<CodeRunResults> Run(CodeRunRequest request)
        {
            var result = new CodeRunResults
            {
                UserConnectionId = request.UserConnectionId,
                ChallengeVersionId = request.ChallengeVersionId,
                Language = request.Language
            };
            string buildProcessName = request.UserId + "_" + request.ChallengeVersionId + "-build";

            var buildLog = await _solutionRunner.RunSolutionBuild(new ContainerDataDto(buildProcessName, request.Language, request.UserCode, request.Tests ?? "", request.Preloaded ?? ""));

            _buildResultBuilder.BuildResults(buildLog, result, result.Language);

            if (result.BuildResults?.IsSuccess ?? false) 
            {
                string testProcessName = request.UserId + "_" + request.ChallengeVersionId + "-testing";

                var testRunResults = await _solutionRunner.RunSolutionTestsAsync(new ContainerDataDto(testProcessName, request.Language, request.UserCode, request.Tests ?? "", request.Preloaded ?? ""));

                result.TestRunResults = testRunResults;
            }

            return result;
        }
    }
}
