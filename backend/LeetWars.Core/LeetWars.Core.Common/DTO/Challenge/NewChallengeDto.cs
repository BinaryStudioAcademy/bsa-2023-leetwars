using LeetWars.Core.DAL.Enums;

namespace LeetWars.Core.DAL.Entities
{
    public class NewChallengeDto
    {
        public long? CreatedBy { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Instructions { get; set; } = string.Empty;
        public int LevelId { get; set; }
        public ChallengeCategory Category { get; set; }
    }
}
