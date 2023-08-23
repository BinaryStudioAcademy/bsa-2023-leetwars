using LeetWars.Core.DAL.Entities;

namespace LeetWars.Core.Common.DTO.Tag
{
    public class TagDto : Entity<int>
    {
        public string Name { get; set; } = string.Empty;    
    }
}
