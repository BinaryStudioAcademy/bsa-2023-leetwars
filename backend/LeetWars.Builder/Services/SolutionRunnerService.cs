using Docker.DotNet;
using Docker.DotNet.Models;
using LeetWars.Builder.Helpers.BuildResultReader;
using LeetWars.Builder.Helpers.DirectoryConfigurations;
using LeetWars.Builder.Helpers.DockerConfigurations;
using LeetWars.Builder.Helpers.RunnerFileWriterReader;
using LeetWars.Builder.Interfaces;
using LeetWars.Builder.Models;
using LeetWars.Builder.Models.HelperModels;
using Newtonsoft.Json;

namespace LeetWars.Builder.Services
{
    public class SolutionRunnerService : ISolutionRunnerService, IDisposable
    {
        private readonly DockerClient _client = new DockerClientConfiguration().CreateClient();

        public async Task<CodeRunResults> Run(CodeRunRequest request)
        {
            var buildResultReader = new BuildResultReader();
            var dirBuilder = new DockerMountDirectoryConfigurations();
            var dockerConfig = new DockerConfigurations();
            RunnerFileWriterReaderClass readWrite = new RunnerFileWriterReaderClass();
            dirBuilder.RFW = readWrite;

            string dir = Directory.GetCurrentDirectory();
            Config config;

            string? solutionFileName;
            switch (request.Language)
            {
                case "C#":
                    var projectFileName = await dirBuilder.CreateDirectoryCSharp(dir, request);

                    await dockerConfig.CreateImage(_client, SDKImageNames.CSharpSDK);

                    solutionFileName = SolutionFileNaming.CSharpSolutionName;
                    config = dockerConfig.GetCSharpConfig(projectFileName);
                    break;

                case "Javascript":
                    dirBuilder.CreateDirectoryJS(dir, request);

                    await dockerConfig.CreateImage(_client, SDKImageNames.JSSDK);

                    solutionFileName = SolutionFileNaming.JSSolutionName;
                    config = dockerConfig.GetJSConfig(solutionFileName);
                    break;
                default:
                    return new CodeRunResults();
            }

            dir = dirBuilder.CurrentDirectory;

            string solutionCode = request.UserCode;

            await readWrite.WriteContentAsync(Path.Combine(dir, solutionFileName), solutionCode);

            var hostConfig = dockerConfig.GetHostConfig();

            var response = await _client.Containers.CreateContainerAsync(new CreateContainerParameters(config)
            {
                HostConfig = hostConfig,
            });

            var containerId = response.ID;

            await _client.Containers.StartContainerAsync(containerId, new ContainerStartParameters());
            await _client.Containers.WaitContainerAsync(containerId);

            string buildLog = ReadContentAsync;

            using (StreamReader buildReader = new StreamReader(Path.Combine(dir, "buildoutput.txt")))
            {
                buildLog = await buildReader.ReadToEndAsync();
            }

            await _client.Containers.RemoveContainerAsync(containerId, new ContainerRemoveParameters { Force = true });

            if (Directory.Exists(dir) && dir != Directory.GetCurrentDirectory())
            {
                Directory.Delete(dir, true);
            }

            var result = new CodeRunResults();

            switch (request.Language)
            {
                case "C#":
                    buildResultReader.BuildResultCSharp(buildLog, result);
                    break;

                case "Javascript":
                    buildResultReader.BuildResultJS(buildLog, result);
                    break;

                default:
                    break;
            }

            result.ChallengeVersionId = request.ChallengeVersionId;
            result.UserId = request.UserId;
            result.Language = request.Language;

            return result;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            _client?.Dispose();
        }
    }
}
