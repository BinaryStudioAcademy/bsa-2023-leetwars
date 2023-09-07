using Docker.DotNet;
using Docker.DotNet.Models;
using LeetWars.Builder.Interfaces;
using LeetWars.Builder.Models;
using Newtonsoft.Json;

namespace LeetWars.Builder.Services
{
    public class SolutionRunnerService : ISolutionRunnerService, IDisposable
    {
        private readonly DockerClient _client = new DockerClientConfiguration().CreateClient();

        public async Task<string?> RunCodeInContainerAsync(string imageName, string containerName)
        {
            //all the data is incoming -- here for testing purposes
            string experimentClassLibrary = "public class Solution\r\n{\r\n    public bool IsNumPrime(int num)\r\n    {\r\n        return (num % 2 == 0);\r\n    }\r\n}\r\n";
            string classLibraryName = "Solution.cs";

            string experimentTests = "using NUnit.Framework;\r\n\r\n[TestFixture]\r\npublic class Tests\r\n{\r\n    private Solution? _solutionClass;\r\n\r\n    [SetUp]\r\n    public void Setup()\r\n    {\r\n        _solutionClass = new Solution();\r\n    }\r\n\r\n    [Test]\r\n    public void IsPrime_InputIs1_ReturnFalse()\r\n    {\r\n        var result = _solutionClass.IsNumPrime(2);\r\n\r\n        Assert.IsFalse(result, \"1 should not be prime\");\r\n    }\r\n}";
            string testFileName = "Tests.cs";

            var volumeName = "myvolume1";
            //

            //Actual logic
            //Create Volume
            await _client.Volumes.CreateAsync(new VolumesCreateParameters
            {
                Name = volumeName
            });

            //Create container and bind a volume with data on it
            var containerParams = new CreateContainerParameters
            {
                Image = imageName,
                Name = containerName,
                HostConfig = new HostConfig
                {
                    Binds = new List<string>
                    {
                        $"{volumeName}:/LocalVolume" // Mount the volume to a mountpoint in the container
                    },
                }
            };

            var container = await _client.Containers.CreateContainerAsync(containerParams);

            //Add needed files to a volume
            await StringToFileInContainerAsync(experimentClassLibrary, classLibraryName, container.ID, "/LocalVolume/");

            await StringToFileInContainerAsync(experimentTests, testFileName, container.ID, "/LocalVolume/");

            //Start action
            await _client.Containers.StartContainerAsync(container.ID, null);

            await _client.Containers.WaitContainerAsync(container.ID);

            //Manipulate data that container outputted
            var stringResult = await FileInContainerToStringAsync(container.ID, "/LocalVolume/testresults.trx");

            var testResultOutput = XmlTestResultParserService.ParseCSharpTestResult(stringResult);

            return stringResult;
        }

        public async Task<BuildResult> RunSolutionBuild(string processName, string code)
        {
            return await RunCSharpBuild(processName, code);
        }

        public async Task<string> RunSolutionTests(string processName, string code, string tests)
        {

            return JsonConvert.SerializeObject(await RunCSharpSolutionTests(processName, code, tests));
        }

        public async Task<CSharpTestOutput> RunCSharpSolutionTests(string containerName, string csharpCode, string csharpTests)
        {
            //Create volume
            var volumeName = containerName + "-volume";

            await _client.Volumes.CreateAsync(new VolumesCreateParameters
            {
                Name = volumeName
            });

            //Create container and bind a volume with data on it
            var containerParams = new CreateContainerParameters
            {
                Image = RunnerDefaults.DefaultRunnerImageNames.CSharpTestImage,
                Name = containerName,
                HostConfig = new HostConfig
                {
                    Binds = new List<string>
                    {
                        $"{volumeName}:/LocalVolume"
                    },
                }
            };

            var container = await _client.Containers.CreateContainerAsync(containerParams);

            //Add needed files to a volume
            await StringToFileInContainerAsync(csharpCode, RunnerDefaults.CSharpFileNaming.SolutionFileName, container.ID, "/LocalVolume/");

            await StringToFileInContainerAsync(csharpTests, RunnerDefaults.CSharpFileNaming.SolutionTestFileName, container.ID, "/LocalVolume/");

            //Start action
            await _client.Containers.StartContainerAsync(container.ID, null);

            await _client.Containers.WaitContainerAsync(container.ID);

            //Manipulate data that container outputted
            var stringResult = await FileInContainerToStringAsync(container.ID, $"/LocalVolume/{RunnerDefaults.CSharpFileNaming.TestResultsFileName}");

            return stringResult != null ? XmlTestResultParserService.ParseCSharpTestResult(stringResult) : throw new ArgumentException("Such file does not exist or is named incorrectly");

        }

        public async Task<BuildResult> RunCSharpBuild(string containerName, string csharpCode)
        {
            //Create volume
            var volumeName = containerName + "-volume";

            await _client.Volumes.CreateAsync(new VolumesCreateParameters
            {
                Name = volumeName
            });

            //Create container and bind a volume with data on it
            var containerParams = new CreateContainerParameters
            {
                Image = RunnerDefaults.DefaultRunnerImageNames.CSharpBuildImage,
                Name = containerName,
                HostConfig = new HostConfig
                {
                    Binds = new List<string>
                    {
                        $"{volumeName}:/LocalVolume"
                    },
                }
            };

            var container = await _client.Containers.CreateContainerAsync(containerParams);

            //Add needed files to a volume
            await StringToFileInContainerAsync(csharpCode, RunnerDefaults.CSharpFileNaming.SolutionFileName, container.ID, "/LocalVolume/");

            //Start action
            await _client.Containers.StartContainerAsync(container.ID, null);

            var containerResponse = await _client.Containers.WaitContainerAsync(container.ID);


            var result = new BuildResult
            {
                IsSuccess = containerResponse.StatusCode == 0
            };

            //Manipulate data that container outputted
            if(containerResponse.StatusCode == 1)
            {
                var errors = await FileInContainerToStringAsync(container.ID, $"/LocalVolume/{RunnerDefaults.CSharpFileNaming.BuildErrorResultsFileName}");
                result.BuildErrorOutput = errors;
            }

            return result;

        }

        private async Task StringToFileInContainerAsync(string input, string newFileNameWithExtenstion, string containerId, string pathInContainer)
        {
            var bytes = TarManagementService.SingleFileToTarBytes(input, newFileNameWithExtenstion);

            using var tarStream = new MemoryStream(bytes) ;
            var archivePath = pathInContainer;

            var putArchiveParams = new ContainerPathStatParameters
            {
                Path = archivePath,
            };

            await _client.Containers.ExtractArchiveToContainerAsync(containerId, putArchiveParams, tarStream, default);
        }

        private async Task<string?> FileInContainerToStringAsync(string containerId, string pathToFileInContainer)
        {
            var data = await _client.Containers.GetArchiveFromContainerAsync(containerId, new GetArchiveFromContainerParameters() { Path = pathToFileInContainer }, false);

            return await TarManagementService.FromTarSingleFileToStringAsync(data.Stream);
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
