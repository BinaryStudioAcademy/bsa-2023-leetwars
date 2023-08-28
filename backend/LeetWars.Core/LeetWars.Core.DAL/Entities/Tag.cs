namespace LeetWars.Core.DAL.Entities
{
    public class Tag : Entity<int>
    {
        public string Name { get; set; }
        public ICollection<Challenge> Challenges { get; } = new List<Challenge>();


        public Tag(string name)
        {
            Name = name;
        }
    }
}
