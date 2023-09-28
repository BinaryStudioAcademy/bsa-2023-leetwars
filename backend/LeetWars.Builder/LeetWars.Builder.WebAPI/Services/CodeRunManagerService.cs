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

        public async Task<CodeRunResults> RunAsync(CodeRunRequest request)
        {
            var result = new CodeRunResults
            {
                UserConnectionId = request.UserConnectionId,
                Language = request.Language
            };

            await BuildCodeAsync(request, result);

            await TestCodeAsync(request, result);

            return result;
        }

        private async Task BuildCodeAsync(CodeRunRequest request, CodeRunResults result)
        {
            string buildProcessName = request.UserConnectionId + DateTime.UtcNow.Ticks + "-build";

            var buildLog = await _solutionRunner.RunSolutionBuildAsync(new ContainerDataDto(buildProcessName, request.Language, request.UserCode, request.Tests ?? "", request.Preloaded ?? ""));

            _buildResultBuilder.BuildResults(buildLog, result, result.Language);

        }

        private async Task TestCodeAsync(CodeRunRequest request, CodeRunResults result)
        {
            if (result.BuildResults?.IsSuccess ?? false)
            {
                string testProcessName = request.UserConnectionId + DateTime.UtcNow.Ticks + "-testing";

                var testRunResults = await _solutionRunner.RunSolutionTestsAsync(new ContainerDataDto(testProcessName, request.Language, request.UserCode, request.Tests ?? "", request.Preloaded ?? ""));

                result.TestRunResults = testRunResults;
            }
        }
    }
}
