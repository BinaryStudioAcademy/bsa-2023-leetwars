using LeetWars.Core.Common.DTO.LanguageVersion;
using LeetWars.Core.DAL.Entities;

namespace LeetWars.Core.Common.DTO.Language
{
    public class LanguageFullDto : Entity<int>
    {
        public string Name { get; set; } = string.Empty;
        public ICollection<LanguageVersionDto>? LanguageVersions { get; set; }
    }
}
