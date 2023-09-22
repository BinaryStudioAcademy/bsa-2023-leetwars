using Docker.DotNet;
using Docker.DotNet.Models;
using LeetWars.Builder.DTO;
using LeetWars.Builder.Interfaces;
using LeetWars.Builder.Models;
using LeetWars.Builder.RunnerDefaults.HelperModels;

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

        public async Task<string> RunSolutionBuildAsync(ContainerDataDto data)
        {
            return data.Language switch 
            {
                Languages.csharp => await RunCSharpBuildAsync(data),
                Languages.javascript => await RunJSBuildAsync(data),
                _ => "",
            };
        }

        public async Task<string> RunCSharpBuildAsync(ContainerDataDto data)
        {
            var volumeName = data.ProcessName + "-volume";
            var container = await CreateContainerWithVolumeAsync(data.ProcessName, volumeName, DefaultRunnerImageNames.CSharpBuildImage, _localVolumeName);
            await StringToFileInContainerAsync(data.Code, DefaultCSharpFileNaming.SolutionFileName, container.ID, $"/{_localVolumeName}/");
            await StringToFileInContainerAsync(data.Preloaded, DefaultCSharpFileNaming.SolutionPreloadedFileName, container.ID, $"/{_localVolumeName}/");
            var buildLog = await RunContainerAndGetResultFile(container.ID, volumeName, $"/{_localVolumeName}/{DefaultCSharpFileNaming.BuildResultsFileName}");
            return buildLog;
        }

        public async Task<string> RunJSBuildAsync(ContainerDataDto data)
        {
            var volumeName = data.ProcessName + "-volume";
            var container = await CreateContainerWithVolumeAsync(data.ProcessName, volumeName, DefaultRunnerImageNames.JSBuildImage, _localVolumeName);
            await StringToFileInContainerAsync(data.Preloaded + Environment.NewLine + data.Code, DefaultJSFileNaming.SolutionCodeFileName, container.ID, $"/{_localVolumeName}/");
            var buildLog = await RunContainerAndGetResultFile(container.ID, volumeName, $"/{_localVolumeName}/{DefaultCSharpFileNaming.BuildResultsFileName}");
            return buildLog;
        }

        public async Task<TestsOutput?> RunSolutionTestsAsync(ContainerDataDto data)
        {
            return data.Language switch
            {
                Languages.csharp => await RunCSharpSolutionTestsAsync(data),
                Languages.javascript => await RunJSSolutionTestsAsync(data),
                _ => null,
            };
        }

        private async Task<TestsOutput> RunCSharpSolutionTestsAsync(ContainerDataDto data)
        {
            var volumeName = data.ProcessName + "-volume";
            var container = await CreateContainerWithVolumeAsync(data.ProcessName, volumeName, DefaultRunnerImageNames.CSharpTestImage, _localVolumeName);
            await StringToFileInContainerAsync(data.Code, DefaultCSharpFileNaming.SolutionFileName, container.ID, $"/{_localVolumeName}/");
            await StringToFileInContainerAsync(data.Tests, DefaultCSharpFileNaming.SolutionTestFileName, container.ID, $"/{_localVolumeName}/");
            await StringToFileInContainerAsync(data.Preloaded, DefaultCSharpFileNaming.SolutionPreloadedFileName, container.ID, $"/{_localVolumeName}/");
            await StringToFileInContainerAsync(TestShellScripts.CSharpTestScript, TestShellScriptNaming.CSharpTestScriptName, container.ID, $"/{_localVolumeName}/");
            var stringResult = await RunContainerAndGetResultFile(container.ID, volumeName, $"/{_localVolumeName}/{DefaultCSharpFileNaming.TestResultsFileName}");
            return _parserService.ParseCSharpTestResult(stringResult);
        }

        private async Task<TestsOutput> RunJSSolutionTestsAsync(ContainerDataDto data)
        {
            var volumeName = data.ProcessName + "-volume";
            var container = await CreateContainerWithVolumeAsync(data.ProcessName, volumeName, DefaultRunnerImageNames.JSTestImage, _localVolumeName);
            var jsCodeWithTests = data.Preloaded + Environment.NewLine + data.Code + Environment.NewLine + data.Tests;
            await StringToFileInContainerAsync(jsCodeWithTests, DefaultJSFileNaming.SolutionCodeFileName, container.ID, $"/{_localVolumeName}/");
            await StringToFileInContainerAsync(TestShellScripts.JSTestScript, TestShellScriptNaming.JSTestScriptName, container.ID, $"/{_localVolumeName}/");
            var stringResult = await RunContainerAndGetResultFile(container.ID, volumeName, $"/{_localVolumeName}/{DefaultJSFileNaming.TestResultsFileName}");
            return _parserService.ParseJSTestResult(stringResult);
        }

        private async Task<CreateContainerResponse> CreateContainerWithVolumeAsync(string containerName, string volumeName, string imageName, string volumeNameInContainer)
        {
            var volumes = await _client.Volumes.ListAsync();
            var volume = volumes.Volumes.FirstOrDefault(v => v.Name == volumeName);

            if(volume is not null)
            {
                await _client.Volumes.RemoveAsync(volumeName, true);
            }

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
