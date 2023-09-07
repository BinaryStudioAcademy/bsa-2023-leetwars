using Docker.DotNet;
using Docker.DotNet.Models;
using LeetWars.Builder.Interfaces;

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
