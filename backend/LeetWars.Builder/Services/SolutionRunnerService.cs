using System.ComponentModel;
using Docker.DotNet;
using Docker.DotNet.Models;
using LeetWars.Builder.DTO;
using LeetWars.Builder.Helpers.BuildResultReader;
using LeetWars.Builder.Helpers.DockerConfigurations;
using LeetWars.Builder.Helpers.RunnerFileWriterReader;
using LeetWars.Builder.Interfaces;
using LeetWars.Builder.Models;
using LeetWars.Builder.Models.HelperModels;
using LeetWars.Builder.RunnerDefaults;
using LeetWars.Builder.RunnerDefaults.CSharp;
using LeetWars.Builder.RunnerDefaults.JS;

namespace LeetWars.Builder.Services
{
    public class SolutionRunnerService : ISolutionRunnerService, IDisposable
    {
        private readonly DockerClient _client = new DockerClientConfiguration().CreateClient();
        private readonly IXmlTestResultParserService _parserService;
        private readonly ITarManagementService _tarManagementService;
        private readonly string _localVolumeName = "LocalVolume";
        public SolutionRunnerService(IXmlTestResultParserService parserService, ITarManagementService tarManagementService)
        {
            _parserService = parserService;
            _tarManagementService = tarManagementService;
        }

        public async Task<CodeRunResults> Run(CodeRunRequest request)
        {
            var buildResultReader = new BuildResultReader();
            var dockerConfig = new DockerConfigurations();
            RunnerFileWriterReaderClass readWrite = new RunnerFileWriterReaderClass();

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

        public async Task<TestsOutput?> RunSolutionTestsAsync(TestingContainerDataDto data)
        {
            return data.Language switch
            {
                Languages.csharp => await RunCSharpSolutionTestsAsync(data),
                Languages.javascript => await RunJSSolutionTestsAsync(data),
                _ => null,
            };
        }

        private async Task<TestsOutput> RunCSharpSolutionTestsAsync(TestingContainerDataDto data)
        {
            var volumeName = data.ProcessName + "-volume";
            var container = await CreateContainerWithVolumeAsync(data.ProcessName, volumeName, DefaultRunnerImageNames.CSharpTestImage, _localVolumeName);
            await StringToFileInContainerAsync(data.Code, DefaultCSharpFileNaming.SolutionFileName, container.ID, $"/{_localVolumeName}/");
            await StringToFileInContainerAsync(data.Tests, DefaultCSharpFileNaming.SolutionTestFileName, container.ID, $"/{_localVolumeName}/");
            await StringToFileInContainerAsync(data.Preloaded, DefaultCSharpFileNaming.SolutionPreloadedFileName, container.ID, $"/{_localVolumeName}/");
            var stringResult = await RunContainerAndGetResultFile(container.ID, volumeName, $"/{_localVolumeName}/{DefaultCSharpFileNaming.TestResultsFileName}");
            return _parserService.ParseCSharpTestResult(stringResult);
        }

        private async Task<TestsOutput> RunJSSolutionTestsAsync(TestingContainerDataDto data)
        {
            var volumeName = data.ProcessName + "-volume";
            var container = await CreateContainerWithVolumeAsync(data.ProcessName, volumeName, DefaultRunnerImageNames.JSTestImage, _localVolumeName);
            var jsCodeWithTests = data.Preloaded + Environment.NewLine + data.Code + Environment.NewLine + data.Tests;
            await StringToFileInContainerAsync(jsCodeWithTests, DefaultJSFileNaming.SolutionTestFileName, container.ID, $"/{_localVolumeName}/");
            var stringResult = await RunContainerAndGetResultFile(container.ID, volumeName, $"/{_localVolumeName}/{DefaultJSFileNaming.TestResultsFileName}");
            return _parserService.ParseJSTestResult(stringResult);
        }

        private async Task<CreateContainerResponse> CreateContainerWithVolumeAsync(string containerName, string volumeName, string imageName, string volumeNameInContainer)
        {
            await _client.Volumes.CreateAsync(new VolumesCreateParameters
            {
                Name = volumeName
            });
            var containerParams = new CreateContainerParameters
            {
                Image = imageName,
                Name = containerName,
                HostConfig = new HostConfig
                {
                    Binds = new List<string>
                    {
                        $"{volumeName}:/{volumeNameInContainer}"
                    },
                }
            };
            return await _client.Containers.CreateContainerAsync(containerParams);
        }

        private async Task<string> RunContainerAndGetResultFile(string containerId, string? volumeName, string path)
        {
            await _client.Containers.StartContainerAsync(containerId, null);
            await _client.Containers.WaitContainerAsync(containerId);

            var stringResult = string.Empty;
            try
            {
                stringResult = await FileInContainerToStringAsync(containerId, path);
            }
            catch (Exception)
            {
                await RemoveContainersAsync(containerId, volumeName);
                return string.Empty;
            }

            await RemoveContainersAsync(containerId, volumeName);

            return stringResult;
        }

        private async Task StringToFileInContainerAsync(string input, string newFileNameWithExtenstion, string containerId, string pathInContainer)
        {
            var bytes = _tarManagementService.SingleFileToTarBytes(input, newFileNameWithExtenstion);
            var putArchiveParams = new ContainerPathStatParameters
            {
                Path = pathInContainer,
            };
            await _client.Containers.ExtractArchiveToContainerAsync(containerId, putArchiveParams, new MemoryStream(bytes), default);
        }

        private async Task<string> FileInContainerToStringAsync(string containerId, string pathToFileInContainer)
        {
            GetArchiveFromContainerResponse data = await _client.Containers.GetArchiveFromContainerAsync(containerId, new GetArchiveFromContainerParameters() { Path = pathToFileInContainer }, false);
            return await _tarManagementService.FromTarSingleFileToStringAsync(data.Stream);
        }

        private async Task RemoveContainersAsync(string containerId, string? volumeName)
        {
            await _client.Containers.RemoveContainerAsync(containerId, new ContainerRemoveParameters { Force = true });
            if (!string.IsNullOrEmpty(volumeName))
            {
                await _client.Volumes.RemoveAsync(volumeName);
            }
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
