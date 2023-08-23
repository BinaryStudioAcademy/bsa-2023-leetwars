namespace LeetWars.Core.DAL.Entities
{
    public class Language : Entity<int>
    {
        public string Name { get; set; }
        public List<User> Users { get; } = new();
        public List<LanguageVersion> LanguageVersions { get; } = new();

        public Language(string name)
        {
            Name = name;
        }
    }
}
