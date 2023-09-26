using LeetWars.Core.DAL.Entities;

namespace LeetWars.Core.Common.DTO.Tag
{
    public class TagDto : Entity<long>
    {
        public string Name { get; set; } = string.Empty;
    }
}
