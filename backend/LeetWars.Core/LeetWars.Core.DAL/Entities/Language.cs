namespace LeetWars.Core.DAL.Entities
{
    public class Language : Entity<int>
    {
        public string Name { get; set; }

        public Language(string name)
        {
            Name = name;
        }
    }
}
