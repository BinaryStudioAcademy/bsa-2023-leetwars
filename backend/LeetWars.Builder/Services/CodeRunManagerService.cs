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
            var result = await _solutionRunner.Run(request);

            return result;
        }
    }
}
