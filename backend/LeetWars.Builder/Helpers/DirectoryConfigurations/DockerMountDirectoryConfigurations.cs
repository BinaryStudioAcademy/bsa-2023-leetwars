using LeetWars.Builder.Helpers.RunnerFileWriterReader;
using LeetWars.Builder.Models;
using LeetWars.Builder.Models.HelperModels;

namespace LeetWars.Builder.Helpers.DirectoryConfigurations;

public class DockerMountDirectoryConfigurations
{
    public string CurrentDirectory { get; set; } = string.Empty;
    public RunnerFileWriterReaderClass RFW { get; set; } = new RunnerFileWriterReaderClass();

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

        await RFW.WriteContentAsync(Path.Combine(CurrentDirectory, projectFileName), ProjectFileContents.CSharpProjectContent);
        await RFW.WriteContentAsync(Path.Combine(CurrentDirectory, programFileName), ProjectFileContents.CSharpProgramContent);

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
