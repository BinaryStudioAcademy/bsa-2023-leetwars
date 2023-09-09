using Docker.DotNet;
using Docker.DotNet.Models;
using LeetWars.Builder.Interfaces;
using LeetWars.Builder.Models;
using LeetWars.Builder.RunnerDefaults;
using LeetWars.Builder.RunnerDefaults.CSharp;
using LeetWars.Builder.RunnerDefaults.JS;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace LeetWars.Builder.Services
{
    public class SolutionRunnerService : ISolutionRunnerService, IDisposable
    {
        private readonly DockerClient _client = new DockerClientConfiguration().CreateClient();

        private readonly IXmlTestResultParserService _parserService;

        private readonly ITarManagementService _tarManagementService;

        private readonly JsonSerializerSettings _serializerSettings = new() { ContractResolver = new CamelCasePropertyNamesContractResolver() };

        private readonly string _localVolumeName = "LocalVolume";


    public SolutionRunnerService(IXmlTestResultParserService parserService, ITarManagementService tarManagementService)
        {
            _parserService = parserService;

            _tarManagementService = tarManagementService;
        }

        public async Task<string> RunSolutionTestsAsync(string processName, string language, string code, string tests, string preloaded)
        {
            return language switch
            {
                "csharp" => JsonConvert.SerializeObject(await RunCSharpSolutionTestsAsync(processName, code, tests, preloaded), _serializerSettings),

                "js" => JsonConvert.SerializeObject(await RunJSSolutionTestsAsync(processName, code, tests, preloaded), _serializerSettings),

                _ => "",
            };
        }

        private async Task<TestsOutput> RunCSharpSolutionTestsAsync(string containerName, string csharpCode, string csharpTests, string preloaded = "")
        {
            var volumeName = containerName + "-volume";

            var container = await CreateContainerWithVolumeAsync(containerName, volumeName, DefaultRunnerImageNames.CSharpTestImage,_localVolumeName);

            await StringToFileInContainerAsync(csharpCode, DefaultCSharpFileNaming.SolutionFileName, container.ID, $"/{_localVolumeName}/");

            await StringToFileInContainerAsync(csharpTests, DefaultCSharpFileNaming.SolutionTestFileName, container.ID, $"/{_localVolumeName}/");

            await StringToFileInContainerAsync(preloaded, DefaultCSharpFileNaming.SolutionPreloadedFileName, container.ID, $"/{_localVolumeName}/");

            await _client.Containers.StartContainerAsync(container.ID, null);

            await _client.Containers.WaitContainerAsync(container.ID);

            var stringResult = await FileInContainerToStringAsync(container.ID, $"/{_localVolumeName}/{DefaultCSharpFileNaming.TestResultsFileName}");

            await _client.Containers.RemoveContainerAsync(container.ID, new ContainerRemoveParameters { Force = true });

            await _client.Volumes.RemoveAsync(volumeName);

            return _parserService.ParseCSharpTestResult(stringResult);

        }

        private async Task<TestsOutput> RunJSSolutionTestsAsync(string containerName, string jsCode, string jsTests, string preloaded = "")
        {
            var volumeName = containerName + "-volume";

            var container = await CreateContainerWithVolumeAsync(containerName, containerName + "-volume",DefaultRunnerImageNames.JSTestImage, _localVolumeName);

            var jsCodeWithTests = preloaded + Environment.NewLine + jsCode + Environment.NewLine + jsTests; 

            await StringToFileInContainerAsync(jsCodeWithTests, DefaultJSFileNaming.SolutionTestFileName, container.ID, $"/{_localVolumeName}/");

            await _client.Containers.StartContainerAsync(container.ID, null);

            await _client.Containers.WaitContainerAsync(container.ID);

            var stringResult = await FileInContainerToStringAsync(container.ID, $"/{_localVolumeName}/{DefaultJSFileNaming.TestResultsFileName}");

            await _client.Containers.RemoveContainerAsync(container.ID, new ContainerRemoveParameters { Force = true });

            await _client.Volumes.RemoveAsync(volumeName);

            return _parserService.ParseJSTestResult(stringResult);
        }

        private async Task<CreateContainerResponse> CreateContainerWithVolumeAsync(string containerName, string volumeName,string imageName,string volumeNameInContainer)
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

        private async Task StringToFileInContainerAsync(string input, string newFileNameWithExtenstion, string containerId, string pathInContainer)
        {
            var bytes = _tarManagementService.SingleFileToTarBytes(input, newFileNameWithExtenstion);

            using var tarStream = new MemoryStream(bytes);

            var archivePath = pathInContainer;

            var putArchiveParams = new ContainerPathStatParameters
            {
                Path = archivePath,
            };

            await _client.Containers.ExtractArchiveToContainerAsync(containerId, putArchiveParams, tarStream, default);
        }

        private async Task<string> FileInContainerToStringAsync(string containerId, string pathToFileInContainer)
        {
            GetArchiveFromContainerResponse data = await _client.Containers.GetArchiveFromContainerAsync(containerId, new GetArchiveFromContainerParameters() { Path = pathToFileInContainer }, false);

            return await _tarManagementService.FromTarSingleFileToStringAsync(data.Stream);
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
