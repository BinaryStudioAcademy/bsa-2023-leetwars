using Docker.DotNet.Models;

namespace LeetWars.Builder.Helpers.DockerConfigurations;

public class DockerConfigurations
{
    public Config GetCSharpConfig(string projectName)
    {
        return new Config
        {
            Image = "mcr.microsoft.com/dotnet/sdk:6.0",
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
            Image = "node:18",
            AttachStdout = true,
            AttachStderr = true,
            Cmd = new[] { "sh", "-c", $"node /app/{programName} 2>&1 |tee /app/buildoutput.txt" },
            Tty = false,
        };
    }
}
