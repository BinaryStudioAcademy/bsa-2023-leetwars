using Docker.DotNet;
using LeetWars.Builder.Interfaces;
using LeetWars.Builder.Models;
using SharpCompress;

namespace LeetWars.Builder.Services
{
    public class CodeRunManagerService : ICodeRunManagerService
    {
        private readonly ISolutionRunnerService _solutionRunner;

        public CodeRunManagerService(ISolutionRunnerService solutionRunner)
        {
            _solutionRunner = solutionRunner;
        }

        public async Task<CodeRunResults> Run(CodeRunRequest request)
        {
            string processNamePrefix = request.UserId + "_" + request.ChallengeVersionId;

            var result =  await RunCode(request, processNamePrefix);

            if (result.BuildResults.IsSuccess && (request.Tests != null || request.Tests != String.Empty))
            {
                result.IsBuilt = true;
                result.TestRunResults = await RunCodeAndTests(request, processNamePrefix);
            }

            return result;
        }

        private async Task<CodeRunResults> RunCode(CodeRunRequest request, string processNamePrefix)
        {
            string processName = processNamePrefix + "code-run";

            return new CodeRunResults
            {
                UserId = request.UserId,
                ChallengeVersionId = request.ChallengeVersionId,
                Language = request.Language,
                BuildResults = await _solutionRunner.RunSolutionBuild(processName, request.UserCode)
            };
        }

        private async Task<string> RunCodeAndTests(CodeRunRequest request, string processNamePrefix)
        {
            string processName = processNamePrefix + "testing";

            string testRunResults = await _solutionRunner.RunSolutionTests(processName, request.UserCode, request.Tests!);
            
            return testRunResults;
        }
    }
}
