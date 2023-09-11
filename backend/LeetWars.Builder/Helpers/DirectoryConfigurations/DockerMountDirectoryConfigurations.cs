using LeetWars.Builder.Helpers.RunnerFileWriterReader;
using LeetWars.Builder.Models;

namespace LeetWars.Builder.Helpers.DirectoryConfigurations;

public class DockerMountDirectoryConfigurations
{
    public string CurrentDirectory { get; set; } = string.Empty;
    public RunnerFileWriterReaderClass RFW { get; set; }

    public async Task<string> CreateDirectoryCSharp(string directoryPath, CodeRunRequest request)
    {
        CurrentDirectory = Path.Combine(directoryPath, $"RunnerDefaults/CSharp/{request.Language}-{request.ChallengeVersionId}-{request.UserId}");

        string programFileName = "Program.cs";
        string projectFileName = $"CSharpRunner-{request.Language}-{request.ChallengeVersionId}-{request.UserId}.csproj";

        if (!Directory.Exists(CurrentDirectory))
        {
            Directory.CreateDirectory(CurrentDirectory);
        }
        else
        {
            Directory.Delete(CurrentDirectory, true);
        }

        string projectFileContent = "<Project Sdk=\"Microsoft.NET.Sdk\">\r\n\r\n  <PropertyGroup>\r\n    <OutputType>Exe</OutputType>\r\n    <TargetFramework>net6.0</TargetFramework>\r\n    <ImplicitUsings>enable</ImplicitUsings>\r\n    <Nullable>enable</Nullable>\r\n  </PropertyGroup>\r\n\r\n</Project>\r\n";
        string programFileContent = "internal class Program\r\n{\r\n    static void Main(string[] args)\r\n    {\r\n        Console.WriteLine(\"Hello, World!\");\r\n    }\r\n}";

        await RFW.WriteContentAsync(Path.Combine(CurrentDirectory, projectFileName), projectFileContent);
        await RFW.WriteContentAsync(Path.Combine(CurrentDirectory, programFileName), programFileContent);

        return projectFileName;
    }

    public void CreateDirectoryJS(string directoryPath, CodeRunRequest request) 
    {
        CurrentDirectory = Path.Combine(directoryPath, $"RunnerDefaults/JS/{request.Language}-{request.ChallengeVersionId}-{request.UserId}");

        if (!Directory.Exists(CurrentDirectory))
        {
            Directory.CreateDirectory(CurrentDirectory);
        }
        else
        {
            Directory.Delete(CurrentDirectory, true);
        }
    }
}
