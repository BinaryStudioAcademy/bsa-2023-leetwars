namespace LeetWars.Core.Common.DTO.UserSolution
{
    public class NewUserSolutionDto
    {
        public long UserId { get; set; }
        public long ChallengeVersionId { get; set; }
        public string Code { get; set; } = string.Empty;
        public string Output { get; set; } = string.Empty;
    }
}
