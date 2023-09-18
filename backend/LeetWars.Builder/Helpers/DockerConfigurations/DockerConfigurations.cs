using System;
using Docker.DotNet;
using Docker.DotNet.Models;
using LeetWars.Builder.Models.HelperModels;
using LeetWars.Builder.Models;
using LeetWars.Builder.Helpers.DirectoryConfigurations;
using LeetWars.Builder.Interfaces;

namespace LeetWars.Builder.Helpers.DockerConfigurations;

public class DockerConfigurations
{
    private readonly DockerMountDirectoryConfigurations dirBuilder = new();
    private readonly ITarManagementService _tarManagementService;

    public DockerConfigurations(ITarManagementService tarManagementService)
    {
        _tarManagementService = tarManagementService;
    }

    public Config GetCSharpConfig(string projectName, string volumeName)
    {

        return new Config
        {
            Image = SdkImageNames.CSharpSDK,
            AttachStdout = true,
            AttachStderr = true,
            Cmd = new[] { "sh", "-c", $"dotnet build /{volumeName}/{projectName} 2>&1 |tee /{volumeName}/buildoutput.txt" },
            Tty = false,
        };
    }

    public Config GetJSConfig(string programName, string volumeName)
    {
        return new Config()
        {
            Image = SdkImageNames.JSSDK,
            AttachStdout = true,
            AttachStderr = true,
            Cmd = new[] { "sh", "-c", $"node /{volumeName}/{programName} 2>&1 |tee /{volumeName}/buildoutput.txt" },
            Tty = false,
        };
    }

    public async Task<Tuple<string, string, Config>> GetConfigurations(
        string language,
        CodeRunRequest request,
        DockerClient client,
        DockerConfigurations dockerConfig
        )
    {
        string solutionFileName = string.Empty;
        string volumeName = string.Empty;
        Config config = new();

        switch (language)
        {
            case Languages.csharp:

                volumeName = $"{request.Language}-{request.ChallengeVersionId}-{request.UserId}";
                await CreateVolumeAsync(volumeName, client);

                var projectFileName = GetSharpProjectName(request.Language, request.ChallengeVersionId, request.UserId);

                await dockerConfig.CreateImage(client, SdkImageNames.CSharpSDK);

                solutionFileName = SolutionFileNaming.CSharpSolutionName;
                config = dockerConfig.GetCSharpConfig(projectFileName, volumeName);
                break;

            case Languages.javascript:
                volumeName = $"{request.Language}-{request.ChallengeVersionId}-{request.UserId}";
                await CreateVolumeAsync(volumeName, client);

                await dockerConfig.CreateImage(client, SdkImageNames.JSSDK);

                solutionFileName = SolutionFileNaming.JSSolutionName;
                config = dockerConfig.GetJSConfig(solutionFileName, volumeName);
                break;
            default:
                break;
        }

        return new Tuple<string, string, Config> (solutionFileName, volumeName, config);
    }

    public async Task CreateImage(DockerClient client, string SDKName)
    {
        var imagePullParams = new ImagesCreateParameters
        {
            FromImage = SDKName
        };

        var progress = new Progress<JSONMessage>();
        await client.Images.CreateImageAsync(imagePullParams, null, progress);
    }

    public HostConfig GetHostConfig(string volumeName)
    {
        return new HostConfig()
        {
            Binds = new List<string>
            {
                $"{volumeName}:/{volumeName}"
            },
        };
    }

    public async Task CreateVolumeAsync(string volumeName, DockerClient client)
    {
        var volumes = await client.Volumes.ListAsync();
        var volume = volumes.Volumes.FirstOrDefault(v => v.Name == volumeName);

        if (volume is not null)
        {
            await client.Volumes.RemoveAsync(volumeName, true);
        }

        await client.Volumes.CreateAsync(new VolumesCreateParameters
        {
            Name = volumeName
        });
    }

    public async Task WriteBuildData(
        CodeRunRequest request,
        string containerId,
        string solutionCode,
        string volumeName,
        DockerClient client,
        string solutionFileName
        )
    {
        switch (request.Language)
        {
            case Languages.csharp:
                await WriteIntoVolumeCS(request, containerId, volumeName, client);
                break;

            case Languages.javascript:
                break;
            default:
                break;
        }

        await StringToFileInContainerAsync(solutionCode, solutionFileName, containerId, volumeName, client);
    }

    public async Task WriteIntoVolumeCS(
        CodeRunRequest request,
        string containerId,
        string volumeName,
        DockerClient client)
    {
        string programFileName = ProjectFileNaming.CSharpProjectName;
        string projectFileName = GetSharpProjectName(request.Language, request.ChallengeVersionId, request.UserId);
        await StringToFileInContainerAsync(ProjectFileContents.CSharpProgramContent, programFileName, containerId, volumeName, client);
        await StringToFileInContainerAsync(ProjectFileContents.CSharpProjectContent, projectFileName, containerId, volumeName, client);
    }

    public async Task StringToFileInContainerAsync(
        string input,
        string newFileNameWithExtenstion,
        string containerId,
        string volumeName,
        DockerClient client)
    {
        var bytes = _tarManagementService.SingleFileToTarBytes(input, newFileNameWithExtenstion);
        var putArchiveParams = new ContainerPathStatParameters
        {
            Path = $"/{volumeName}/",
        };
        await client.Containers.ExtractArchiveToContainerAsync(containerId, putArchiveParams, new MemoryStream(bytes), default);
    }

    public string GetSharpProjectName(string language, long challengeId, long userId)
    {
        return $"CSharpRunner-{language}-{challengeId}-{userId}.csproj";
    }
}
