namespace LeetWars.Core.DAL.Entities
{
    public class NewChallengeDto
    {
        public long AuthorId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Instructions { get; set; } = string.Empty;
        public int LevelId { get; set; }
    }
}
