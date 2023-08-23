namespace LeetWars.Core.DAL.Entities
{
    public class Tag : Entity<int>
    {
        public string Name { get; set; }
        public List<Challenge> Challenges { get; } = new();


        public Tag(string name)
        {
            Name = name;
        }
    }
}
