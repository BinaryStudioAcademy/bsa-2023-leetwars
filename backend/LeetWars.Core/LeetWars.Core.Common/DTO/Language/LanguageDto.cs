using LeetWars.Core.DAL.Entities;

namespace LeetWars.Core.Common.DTO.Language
{
    public class LanguageDto : Entity<long>
    {
        public string Name { get; set; } = string.Empty;
    }
}
