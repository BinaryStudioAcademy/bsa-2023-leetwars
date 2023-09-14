namespace LeetWars.Core.Common.DTO.CodeRunRequest;
public class CodeRunRequestDto
{
    public string UserConnectionId { get; set; } = string.Empty;
    public long UserId { get; set; }
    public long ChallengeVersionId { get; set; }
    public string Language { get; set; } = string.Empty;
    public string UserCode { get; set; } = string.Empty;

    public string? Preloaded { get; set; }
    public string? Tests { get; set; }
}