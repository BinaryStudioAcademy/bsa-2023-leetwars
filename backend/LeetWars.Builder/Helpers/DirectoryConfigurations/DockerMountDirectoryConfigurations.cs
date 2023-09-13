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
        CurrentDirectory = Path.Combine(directoryPath, $"RunnerDefaults/CSharp/{request.Language}-{request.ChallengeVersionId}-{request.UserConnectionId}");

        string programFileName = ProjectFileNaming.CSharpProjectName;
        string projectFileName = $"CSharpRunner-{request.Language}-{request.ChallengeVersionId}-{request.UserConnectionId}.csproj";

        CheckDirectory(CurrentDirectory);

        await RFW.WriteContentAsync(Path.Combine(CurrentDirectory, projectFileName), ProjectFileContents.CSharpProjectContent);
        await RFW.WriteContentAsync(Path.Combine(CurrentDirectory, programFileName), ProjectFileContents.CSharpProgramContent);

        return projectFileName;
    }

    public void CreateDirectoryJS(string directoryPath, CodeRunRequest request) 
    {
        CurrentDirectory = Path.Combine(directoryPath, $"RunnerDefaults/JS/{request.Language}-{request.ChallengeVersionId}-{request.UserConnectionId}");

        CheckDirectory(CurrentDirectory);
    }

    private static void CheckDirectory(string path)
    {
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }
        else
        {
            Directory.Delete(path, true);
        }
    }
}
