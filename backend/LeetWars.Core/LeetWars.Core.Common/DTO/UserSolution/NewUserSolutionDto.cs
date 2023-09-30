namespace LeetWars.Core.Common.DTO.UserSolution
{
    public class NewUserSolutionDto
    {
        public long CreatedBy { get; set; }
        public long ChallengeId { get; set; }
        public long ChallengeVersionId { get; set; }
        public string Code { get; set; } = string.Empty;
        public string Output { get; set; } = string.Empty;
    }
}
