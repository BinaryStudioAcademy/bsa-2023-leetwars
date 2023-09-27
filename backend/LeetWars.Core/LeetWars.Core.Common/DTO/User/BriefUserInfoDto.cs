using LeetWars.Core.DAL.Entities;

namespace LeetWars.Core.Common.DTO.User
{
    public class BriefUserInfoDto : Entity<long>
    {
        public string UserName { get; set; } = String.Empty;
        public string? ImagePath { get; set; }
    }
}
