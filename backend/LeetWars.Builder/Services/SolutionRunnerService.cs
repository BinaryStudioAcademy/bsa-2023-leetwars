using System.IO;
using System;
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
            var dockerConfig = new DockerConfigurations();
            RunnerFileWriterReaderClass readWrite = new RunnerFileWriterReaderClass();
            var dirBuilder = new DockerMountDirectoryConfigurations();

            string dir = Directory.GetCurrentDirectory();

            var configurationResults = await dockerConfig.GetConfigurations(
                request.Language,
                dir,
                request,
                _client,
                dockerConfig
                );

            string? solutionFileName = configurationResults.Item1;

            dir = configurationResults.Item2;

            Config config = configurationResults.Item3;

            string solutionCode = request.UserCode;

            await readWrite.WriteContentAsync(Path.Combine(dir, solutionFileName), solutionCode);

            var hostConfig = dockerConfig.GetHostConfig(dir);

            var response = await _client.Containers.CreateContainerAsync(new CreateContainerParameters(config)
            {
                HostConfig = hostConfig,
            });

            var containerId = response.ID;

            await _client.Containers.StartContainerAsync(containerId, new ContainerStartParameters());
            await _client.Containers.WaitContainerAsync(containerId);

            string buildLog = await readWrite.ReadContentAsync(Path.Combine(dir, "buildoutput.txt"));

            await _client.Containers.RemoveContainerAsync(containerId, new ContainerRemoveParameters { Force = true });

            if (Directory.Exists(dir) && dir != Directory.GetCurrentDirectory())
            {
                Directory.Delete(dir, true);
            }

            var result = new CodeRunResults();

            buildResultReader.BuildResults(buildLog, result, request.Language);

            result.ChallengeVersionId = request.ChallengeVersionId;
            result.UserConnectionId = request.UserConnectionId;
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
