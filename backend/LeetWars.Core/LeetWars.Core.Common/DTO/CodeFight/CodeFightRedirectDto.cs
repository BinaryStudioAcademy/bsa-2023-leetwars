namespace LeetWars.Core.Common.DTO.CodeFight
{
    public class CodeFightRedirectDto
    {
        public string SenderId { get; set; } = string.Empty;
        public string ReceiverId { get; set; } = string.Empty;
        public long ChallengeId { get; set; }
    }
}
