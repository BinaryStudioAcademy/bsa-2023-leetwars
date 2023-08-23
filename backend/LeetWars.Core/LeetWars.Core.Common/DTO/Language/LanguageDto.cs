using LeetWars.Core.DAL.Entities;

namespace LeetWars.Core.Common.DTO.Language
{
    public class LanguageDto : Entity<int>
    {
        public string Name { get; set; } = string.Empty;
    }
}
