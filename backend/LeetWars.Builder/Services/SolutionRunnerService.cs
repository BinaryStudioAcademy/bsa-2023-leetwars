using Docker.DotNet;
using Docker.DotNet.Models;
using LeetWars.Builder.Helpers.BuildResultReader;
using LeetWars.Builder.Helpers.DirectoryConfigurations;
using LeetWars.Builder.Helpers.DockerConfigurations;
using LeetWars.Builder.Interfaces;
using LeetWars.Builder.Models;
using Newtonsoft.Json;

namespace LeetWars.Builder.Services
{
    public class SolutionRunnerService : ISolutionRunnerService, IDisposable
    {
        private readonly DockerClient _client = new DockerClientConfiguration().CreateClient();

        public async Task<CodeRunResults> Run(CodeRunRequest request)
        {
            var reader = new BuildResultReader();
            var dirBuilder = new DirectoryConfigurations();
            var dockerConfig = new DockerConfigurations();

            var dir = Directory.GetCurrentDirectory();
            var solutionFileName = "";

            var config = new Config();

            if(request.Language == "C#")
            {
                var projectFileName = await dirBuilder.CreateDirectoryCSharp(dir, request);

                var imagePullParams = new ImagesCreateParameters
                {
                    FromImage = "mcr.microsoft.com/dotnet/sdk:6.0"
                };

                var progress = new Progress<JSONMessage>();
                await _client.Images.CreateImageAsync(imagePullParams, null, progress);

                solutionFileName = "Solution.cs";

                config = dockerConfig.GetCSharpConfig(projectFileName);
            }

            if(request.Language == "javascript")
            {
                dirBuilder.CreateDirectoryJS(dir, request);

                var imagePullParams = new ImagesCreateParameters
                {
                    FromImage = "node:18"
                };

                var progress = new Progress<JSONMessage>();
                await _client.Images.CreateImageAsync(imagePullParams, null, progress);

                solutionFileName = "Solution.js";

                config = dockerConfig.GetJSConfig(solutionFileName);
            }

            dir = dirBuilder.CurrentDirectory;

            string solutionCode = request.UserCode;

            using (StreamWriter writer = File.CreateText(Path.Combine(dir, solutionFileName)))
            {
                await writer.WriteAsync(solutionCode);
            }

            var hostConfig = new HostConfig()
            {
                Mounts = new List<Mount>
                {
                    new Mount
                    {
                        Type = "bind",
                        Source = $"{dir}",
                        Target = "/app",
                    },
                },
            };

            var response = await _client.Containers.CreateContainerAsync(new CreateContainerParameters(config)
            {
                HostConfig = hostConfig,
            });

            var containerId = response.ID;

            await _client.Containers.StartContainerAsync(containerId, new ContainerStartParameters());

            await _client.Containers.WaitContainerAsync(containerId);

            string buildLog;

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

            if(request.Language == "C#")
            {
                reader.BuildResultCSharp(buildLog, result);
            }

            if(request.Language == "javascript")
            {
                reader.BuildResultJS(buildLog, result);
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
