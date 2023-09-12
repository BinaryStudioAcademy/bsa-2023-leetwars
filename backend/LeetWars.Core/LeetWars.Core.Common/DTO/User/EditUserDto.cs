using LeetWars.Core.Common.DTO.Challenge;

namespace LeetWars.Core.Common.DTO.User
{
    public class EditUserDto
    {
        public long Id { get; set; }

        public long CompletedChallengeId { get; set; }
    }
}
