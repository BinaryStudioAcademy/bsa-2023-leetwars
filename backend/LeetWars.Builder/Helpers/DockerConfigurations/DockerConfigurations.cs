using System;
using Docker.DotNet;
using Docker.DotNet.Models;
using LeetWars.Builder.Models.HelperModels;
using LeetWars.Builder.Models;
using LeetWars.Builder.Helpers.DirectoryConfigurations;

namespace LeetWars.Builder.Helpers.DockerConfigurations;

public class DockerConfigurations
{
    private readonly DockerMountDirectoryConfigurations dirBuilder = new();

    public Config GetCSharpConfig(string projectName)
    {

        return new Config
        {
            Image = SDKImageNames.CSharpSDK,
            AttachStdout = true,
            AttachStderr = true,
            Cmd = new[] { "sh", "-c", $"dotnet build /app/{projectName} 2>&1 |tee /app/buildoutput.txt" },
            Tty = false,
        };
    }

    public Config GetJSConfig(string programName)
    {
        return new Config()
        {
            Image = SDKImageNames.JSSDK,
            AttachStdout = true,
            AttachStderr = true,
            Cmd = new[] { "sh", "-c", $"node /app/{programName} 2>&1 |tee /app/buildoutput.txt" },
            Tty = false,
        };
    }

    public async Task<Tuple<string, string, Config>> GetConfigurations(
        string language,
        string path,
        CodeRunRequest request,
        DockerClient client,
        DockerConfigurations dockerConfig
        )
    {
        string solutionFileName = "";
        Config config = new();

        switch (language)
        {
            case Languages.csharp:
                var projectFileName = await dirBuilder.CreateDirectoryCSharp(path, request);

                await dockerConfig.CreateImage(client, SDKImageNames.CSharpSDK);

                solutionFileName = SolutionFileNaming.CSharpSolutionName;
                config = dockerConfig.GetCSharpConfig(projectFileName);
                break;

            case Languages.javascript:
                dirBuilder.CreateDirectoryJS(path, request);

                await dockerConfig.CreateImage(client, SDKImageNames.JSSDK);

                solutionFileName = SolutionFileNaming.JSSolutionName;
                config = dockerConfig.GetJSConfig(solutionFileName);
                break;
            default:
                break;
        }

        return new Tuple<string, string, Config> (solutionFileName, dirBuilder.CurrentDirectory, config);
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

    public HostConfig GetHostConfig(string path)
    {
        return new HostConfig()
        {
            Mounts = new List<Mount>
                {
                    new Mount
                    {
                        Type = "bind",
                        Source = $"{path}",
                        Target = "/app",
                    },
                },
        };
    }
}
