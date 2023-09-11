using LeetWars.Core.Common.DTO.Challenge;
using LeetWars.Core.Common.DTO.UserSolution;

namespace LeetWars.Core.Common.DTO.User
{
    public class EditUserDto
    {
        public string Uid { get; set; } = string.Empty;

        public ChallengeDto CompletedChallenge { get; set; } = null!;
    }
}
