namespace LeetWars.Core.DAL.Entities
{
    public class LanguageVersion : Entity<int>
    {
        public int LanguageId { get; set; }
        public string Version { get; set; }

        public LanguageVersion(string version)
        {
            Version = version;
        }
    }
}
