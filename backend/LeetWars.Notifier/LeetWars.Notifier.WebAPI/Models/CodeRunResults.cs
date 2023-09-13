namespace LeetWars.Notifier.WebAPI.Models;

public class CodeRunResults
{
    public string UserConnectionId { get; set; } = string.Empty;
    public long ChallengeVersionId { get; set; }
    public string Language { get; set; } = string.Empty;
    public BuildResult? BuildResults { get; set; }
    public string? TestRunResults { get; set; }
}
