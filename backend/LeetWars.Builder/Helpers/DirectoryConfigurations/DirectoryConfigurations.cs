using LeetWars.Builder.Models;

namespace LeetWars.Builder.Helpers.DirectoryConfigurations;

public class DirectoryConfigurations
{
    public string? CurrentDirectory { get; set; }

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

        using (StreamWriter writer = File.CreateText(Path.Combine(CurrentDirectory, projectFileName)))
        {
            writer.WriteLine(projectFileContent);
        }

        using (StreamWriter writer = File.CreateText(Path.Combine(CurrentDirectory, programFileName)))
        {
            await writer.WriteAsync(programFileContent);
        }

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
